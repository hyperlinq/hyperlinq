Hyperlinq on Nuget:
https://www.nuget.org/packages/Hyperlinq

## What's the motivation behind Hyperlinq?

There were several aspects of ASP.NET Razor that were problematic for my project:

1. I found the partial view mechanism unwieldy. Factoring out common HTML code was tedious; eliminating code duplication was a battle, not a breeze. I found myself reluctant to refactor views I knew weren't correctly designed.
2. I found interweaving c# code and html code ugly. Sure, it was better with Razor, but still not good enough.
3. I found my project was littered with too many files, where I spent far too much time navigating, creating, renaming, and deleting them (along with adjusting the references to those files). Poor workflow. I believe in separating concerns; not scattering concerns. Ordinary C# code is really agnostic with file organization. Razor code isn't and I don't like the prescribed organization.
4. I felt uncomfortable choosing between writing an HtmlHelper vs. a partial views, when there were pros and cons of each. Why must there be entirely separate mechanisms? It's not optimal.
5. I felt there like I was writing in a framework not designed with static typing in mind (which is true because ASP.NET MVC was inspired by Ruby on Rails, a dynamic language). For example, why are calls to partial views and controller methods untyped? It makes refactoring painful. It's C#! This sort of problem is solved by using types, not strings.
6. I felt there were too many unnecessarily specialized constructs in Razor. Often constructs that were just ports of C# features with their own syntax, along with arbitrary limitations. Why couldn't I pass in a generic T as part of the model for my partial view? Isn't a layout really just a view with optional parameters? How does the nested layout mechanism work and what can and can't it do? And I don't want to _wait_ for the next release of MVC to hopefully finally get just the most upvoted features; I want an easy general mechanism where I can have all of these things _now_.

I then asked myself the question: is C# really incapable of building an object model that can describe a UI? Because it it was, it would eliminate all of the above problems. I knew Linq to XML already lets you do a decent job of building a DOM; it just wasn't terse and typed. So I came up with a way to building a DOM that was terse and typed.

Here's a layout in Hyperlinq:

    HElement Layout (object main, object sideBar = null)
    {
        return
            H.body (
                H.div (a => a.css ("main"), main),
                H.div (a => a.css ("sideBar"), sideBar)
            );
    }

What's notable is that's there's nothing notable. It's just plain C# code. C#'s optional parameters are used for optional elements rendered in the layout. Hyperlinq's element constructors work in the same way Linq to XML's element constructor's work. Null elements melt away. Elements that are enumerables are automatically expanded out. This makes constructing child elements easy:

    H.ul (
        H.li ("One"),
        from item in new[]
        {
            "Two",
            "Three"
        }
        select H.li (item)
    )

## When should I use Hyperlinq?

I'm definitely not _always_ recommending Hyperlinq for html generation. I think that for writing _documents_, where the content is not generated and cannot be generalized, as opposed to a heavily databound page, that a markdown language is the right choice.

## Isn't it bad to write HTML with C# code? Doesn't that violate the separation of concerns between UI code and business logic?

No. Suppose you want `A` to depend on `B` but not vice-versa. That's trivial to code. It's illusory that writing `A` in separate language (e.g. Razor) or housing `A` in a separate file (*.cshtml) to `B` necessarily helps. Sometimes it actually encourages hacks, and furthermore hacks that are harder for maintenance programmers to see.

## Is there any special support for writing URLs?

Yes.  The idea is that you can call methods in your API that map to url routes in a statically typed manner. The `H` class has a method `Url` that takes an `Expression` and converts it into a `string` (the url). Its usage is as follows:

    H.Url(() => Contact("bob"))

This will produce the following URL:

    /contact/bob

A hyperlinq that generated that URL might be coded as follows:

    H.A (() => Contact(model.Name), model.DisplayName)

`H.A()` is a helper method that translates down to the lower level approach of explicitly setting the `href` attribute:

    H.a (a => a.href (H.Url(() => Contact(model.Name)), model.DisplayName)
  
The default implementation of `Url` is to concatenate the method name with the arguments, each prefixed with a forward slash. That implementation can be swapped by modifying the `UrlResolver` property, a `Func` that takes an `Expression` and returns a `string` (the url). For MVC, an implementation that queried the routing objects would be used.

## How do I output an entire document, rather than an element?

Call `H.Doc (...)`. This essentially does the same thing as calling `H.html`, except it returns an `HDoc` rather than an `HElement`, with an override of `ToString()` that prefixes the `<html>` element with the document type.

## How do I write a method that takes attributes as an argument?

As follows:

    HElement MyForm (ChainFunc<HAttributes.form> extraAttributes)
    {       
        return             
            H.form (a => a.method ("post")
                          .Merge (extraAttributes));
    }

To call:

    MyForm (a => a.enctype("multipart/form-data"))

## Where are the HTML events?

To avoid clutter, HTML events such as click, aren't available for each item. There are two workarounds for this.

1. Use `a => a.Custom ("click", "...")`
2. Use JQuery to hook up the events, where the event binds based on an element's `id`, `name`, or `class`.

`Custom` lets you specify any attribute that doesn't have a static helper method.

## How was the H file generated?

It was auto generated using a T4 template, where the input is a list of HTML elements, and the attributes each HTML element supports. The template references the HyperlinqCodeGenSource project, which provides the list of HTML elements and attributes to convert into the C# object model.

## Known Issues

The list of elements and attributes and XML documentation for intellisense on those elements and attributes were scraped somewhere of the internet - can't remember where, but those sources might not be reliable.

## Is there any special support for CSS?

Using a T4 template, you could generate a c# file by scanning the CSS or .less files in the project, such that you can refer to CSS classes statically.
