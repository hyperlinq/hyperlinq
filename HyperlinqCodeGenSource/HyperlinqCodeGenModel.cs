using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyperlinq
{
    class TElementDescription
    {
        public string Name;
        public string Description;

        public TElementDescription (string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }

    class TElementWithCustomAttributes
    {
        public string Name;
        public string[] Attributes;

        public TElementWithCustomAttributes (string name, string[] attributes)
        {
            this.Name = name;
            this.Attributes = attributes;
        }
    }

    class TAttributeDescription
    {
        public string Name;
        public string Description;

        public TAttributeDescription (string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }
    }

    public class TElementInfo
    {
        public string Name;
        public string SafeName;
        public string[] Attributes;
        public string ImplementedInterfaces;
        public string Summary;
    }

    public class TAttributeInfo
    {
        public string Name;
        public string SafeName;
        public string InterfaceName;
        public string InterfaceNameWithComma;
        public string Summary;
        public bool IsGlobal;
    }

    public static class HyperlinqCodeGenModel
    {
        static TElementDescription[] ElementDescriptions = new[]
        {
		    new TElementDescription ("a",  @"Defines a hyperlink."), 
		    new TElementDescription ("abbr", @"Defines an abbreviation."), 
		    new TElementDescription ("acronym", @"Not supported in HTML5. Defines an acronym."), 
		    new TElementDescription ("address", @"Defines contact information for the author/owner of a document."), 
		    new TElementDescription ("applet", @"Not supported in HTML5. Deprecated in HTML 4.01. Defines an embedded applet."), 
		    new TElementDescription ("area", @"Defines an area inside an image-map."), 
		    new TElementDescription ("article", @"Defines an article."), 
		    new TElementDescription ("aside", @"Defines content aside from the page content."), 
		    new TElementDescription ("audio", @"Defines sound content."), 
		    new TElementDescription ("b", @"Defines bold text."), 
		    new TElementDescription ("base", @"Specifies the base URL/target for all relative URLs in a document."), 
		    new TElementDescription ("basefont", @"Not supported in HTML5. Deprecated in HTML 4.01. Specifies a default colour, size, and font for all text in a document."), 
		    new TElementDescription ("bdi", @"Isolates a part of text that might be formatted in a different direction from other text outside it."), 
		    new TElementDescription ("bdo", @"Overrides the current text direction."), 
		    new TElementDescription ("big", @"Not supported in HTML5. Defines big text."), 
		    new TElementDescription ("blockquote", @"Defines a section that is quoted from another source."), 
		    new TElementDescription ("body", @"Defines the document's body."), 
		    new TElementDescription ("br", @"Defines a single line break."), 
		    new TElementDescription ("canvas", @"Used to draw graphics, on the fly, via scripting (usually JavaScript)."), 
		    new TElementDescription ("caption", @"Defines a table caption."), 
		    new TElementDescription ("center", @"Not supported in HTML5. Deprecated in HTML 4.01. Defines centred text."), 
		    new TElementDescription ("cite", @"Defines the title of a work."), 
		    new TElementDescription ("code", @"Defines a piece of computer code."), 
		    new TElementDescription ("col", @"Specifies column properties for each column within a <colgroup> element ."), 
		    new TElementDescription ("colgroup", @"Specifies a group of one or more columns in a table for formatting."), 
		    new TElementDescription ("command", @"Defines a command button that a user can invoke."), 
		    new TElementDescription ("datalist", @"Specifies a list of pre-defined options for input controls."), 
		    new TElementDescription ("dd", @"Defines a description of an item in a definition list."), 
		    new TElementDescription ("del", @"Defines text that has been deleted from a document."), 
		    new TElementDescription ("details", @"Defines additional details that the user can view or hide."), 
		    new TElementDescription ("dfn", @"Defines a definition term."), 
		    new TElementDescription ("dialog", @"Defines a dialog box or window."), 
		    new TElementDescription ("dir", @"Not supported in HTML5. Deprecated in HTML 4.01. Defines a directory list."), 
		    new TElementDescription ("div", @"Defines a section in a document."), 
		    new TElementDescription ("dl", @"Defines a definition list."), 
		    new TElementDescription ("dt", @"Defines a term (an item) in a definition list."), 
		    new TElementDescription ("em", @"Defines emphasized text ."), 
		    new TElementDescription ("embed", @"Defines a container for an external (non-HTML) application."), 
		    new TElementDescription ("fieldset", @"Groups related elements in a form."), 
		    new TElementDescription ("figcaption", @"Defines a caption for a <figure> element."), 
		    new TElementDescription ("figure", @"Specifies self-contained content."), 
		    new TElementDescription ("font", @"Not supported in HTML5. Deprecated in HTML 4.01. Defines font, colour, and size for text."), 
		    new TElementDescription ("footer", @"Defines a footer for a document or section."), 
		    new TElementDescription ("form", @"Defines an HTML form for user input."), 
		    new TElementDescription ("frame", @"Not supported in HTML5. Defines a window (a frame) in a frameset."), 
		    new TElementDescription ("frameset", @"Not supported in HTML5. Defines a set of frames."), 
		    new TElementDescription ("h1", @"Defines HTML headings."), 
		    new TElementDescription ("h2", @"Defines HTML headings."), 
		    new TElementDescription ("h3", @"Defines HTML headings."), 
		    new TElementDescription ("h4", @"Defines HTML headings."), 
		    new TElementDescription ("h5", @"Defines HTML headings."), 
		    new TElementDescription ("h6", @"Defines HTML headings."), 
		    new TElementDescription ("head", @"Defines information about the document."), 
		    new TElementDescription ("header", @"Defines a header for a document or section."), 
		    new TElementDescription ("hgroup", @"Groups heading (<h1> to <h6>) elements."), 
		    new TElementDescription ("hr", @"Defines a thematic change in the content."), 
		    new TElementDescription ("html", @"Defines the root of an HTML document."), 
		    new TElementDescription ("i", @"Defines a part of text in an alternate voice or mood."), 
		    new TElementDescription ("iframe", @"Defines an inline frame."), 
		    new TElementDescription ("img", @"Defines an image."), 
		    new TElementDescription ("input", @"Defines an input control."), 
		    new TElementDescription ("ins", @"Defines a text that has been inserted into a document."), 
		    new TElementDescription ("kbd", @"Defines keyboard input."), 
		    new TElementDescription ("keygen", @"Defines a key-pair generator field (for forms)."), 
		    new TElementDescription ("label", @"Defines a label for an <input> element."), 
		    new TElementDescription ("legend", @"Defines a caption for a <fieldset>, < figure>, or <details> element."), 
		    new TElementDescription ("li", @"Defines a list item."), 
		    new TElementDescription ("link", @"Defines the relationship between a document and an external resource (most used to link to style sheets)."), 
		    new TElementDescription ("map", @"Defines a client-side image-map."), 
		    new TElementDescription ("mark", @"Defines marked/highlighted text."), 
		    new TElementDescription ("menu", @"Defines a list/menu of commands."), 
		    new TElementDescription ("meta", @"Defines metadata about an HTML document."), 
		    new TElementDescription ("meter", @"Defines a scalar measurement within a known range (a gauge)."), 
		    new TElementDescription ("nav", @"Defines navigation links."), 
		    new TElementDescription ("noframes", @"Not supported in HTML5. Defines an alternate content for users that do not support frames."), 
		    new TElementDescription ("noscript", @"Defines an alternate content for users that do not support client-side scripts."), 
		    new TElementDescription ("object", @"Defines an embedded object."), 
		    new TElementDescription ("ol", @"Defines an ordered list."), 
		    new TElementDescription ("optgroup", @"Defines a group of related options in a drop-down list."), 
		    new TElementDescription ("option", @"Defines an option in a drop-down list."), 
		    new TElementDescription ("output", @"Defines the result of a calculation."), 
		    new TElementDescription ("p", @"Defines a paragraph."), 
		    new TElementDescription ("param", @"Defines a parameter for an object."), 
		    new TElementDescription ("pre", @"Defines pre-formatted text."), 
		    new TElementDescription ("progress", @"Represents the progress of a task."), 
		    new TElementDescription ("q", @"Defines a short quotation."), 
		    new TElementDescription ("rp", @"Defines what to show in browsers that do not support ruby annotations."), 
		    new TElementDescription ("rt", @"Defines an explanation/pronunciation of characters (for East Asian typography)."), 
		    new TElementDescription ("ruby", @"Defines a ruby annotation (for East Asian typography)."), 
		    new TElementDescription ("s", @"Defines text that is no longer correct."), 
		    new TElementDescription ("samp", @"Defines sample output from a computer program."), 
		    new TElementDescription ("script", @"Defines a client-side script."), 
		    new TElementDescription ("section", @"Defines a section in a document."), 
		    new TElementDescription ("select", @"Defines a drop-down list."), 
		    new TElementDescription ("small", @"Defines smaller text."), 
		    new TElementDescription ("source", @"Defines multiple media resources for media elements (<video> and <audio>)."), 
		    new TElementDescription ("span", @"Defines a section in a document."), 
		    new TElementDescription ("strike", @"Not supported in HTML5. Deprecated in HTML 4.01. Defines strike-through text."), 
		    new TElementDescription ("strong", @"Defines important text."), 
		    new TElementDescription ("style", @"Defines style information for a document."), 
		    new TElementDescription ("sub", @"Defines subscripted text."), 
		    new TElementDescription ("summary", @"Defines a visible heading for a <details> element."), 
		    new TElementDescription ("sup", @"Defines superscripted text."), 
		    new TElementDescription ("table", @"Defines a table."), 
		    new TElementDescription ("tbody", @"Groups the body content in a table."), 
		    new TElementDescription ("td", @"Defines a cell in a table."), 
		    new TElementDescription ("textarea", @"Defines a multi-line input control (text area)."), 
		    new TElementDescription ("tfoot", @"Groups the footer content in a table."), 
		    new TElementDescription ("th", @"Defines a header cell in a table."), 
		    new TElementDescription ("thead", @"Groups the header content in a table."), 
		    new TElementDescription ("time", @"Defines a date/time."), 
		    new TElementDescription ("title", @"Defines a title for the document."), 
		    new TElementDescription ("tr", @"Defines a row in a table."), 
		    new TElementDescription ("track", @"Defines text tracks for media elements (<video> and <audio>)."), 
		    new TElementDescription ("tt", @"Not supported in HTML5. Defines Teletype text."), 
		    new TElementDescription ("u", @"Defines text that should be stylistically different from normal text."), 
		    new TElementDescription ("ul", @"Defines an unordered list."), 
		    new TElementDescription ("var", @"Defines a variable."), 
		    new TElementDescription ("video", @"Defines a video or movie."), 
		    new TElementDescription ("wbr", @"Defines a possible line-break.")
        };

        static string[] GlobalAttributes = new string[] { "accesskey", "class", "contenteditable", "contextmenu", "data-custom", "dir", "draggable", "dropzone", "hidden", "id", "itemprop", "lang", "spellcheck", "style", "tabindex", "title" };

        static TAttributeDescription[] AttributeDescriptions = new[]        
        {
		    new TAttributeDescription ("accept", @"List of types the server accepts, typically a file type."), 
		    new TAttributeDescription ("accept-charset", @"List of supported charsets."), 
		    new TAttributeDescription ("accesskey", @"Defines a keyboard shortcut to activate or add focus to the element."), 
		    new TAttributeDescription ("action", @"The URI of a program that processes the information submitted via the form."), 
		    new TAttributeDescription ("align", @"Specifies the horizontal alignment of the element."), 
		    new TAttributeDescription ("alt", @"Alternative text in case an image can't be displayed."), 
		    new TAttributeDescription ("async", @"Indicates that the script should be executed asynchronously."), 
		    new TAttributeDescription ("autocomplete", @"Indicates whether controls in this form can by default have their values automatically completed by the browser."), 
		    new TAttributeDescription ("autofocus", @"The element should be automatically focused after the page loaded."), 
		    new TAttributeDescription ("autoplay", @"The audio or video should play as soon as possible."), 
		    new TAttributeDescription ("buffered", @"Contains the time range of already buffered media."), 
		    new TAttributeDescription ("challenge", @"A challenge string that is submitted along with the public key."), 
		    new TAttributeDescription ("charset", @"Declares the character encoding of the page or script."), 
		    new TAttributeDescription ("checked", @"Indicates whether the element should be checked on page load."), 
		    new TAttributeDescription ("cite", @"Contains a URI which points to the source of the quote or change."), 
		    new TAttributeDescription ("class", @"Often used with CSS to style elements with common properties."), 
		    new TAttributeDescription ("code", @"Specifies the URL of the applet's class file to be loaded and executed."), 
		    new TAttributeDescription ("codebase", @"This attribute gives the absolute or relative URL of the directory where applets' .class files referenced by the code attribute are stored."), 
		    new TAttributeDescription ("cols", @"Defines the number of columns in a textarea."), 
		    new TAttributeDescription ("colspan", @"The colspan attribute defines the number of columns a cell should span."), 
		    new TAttributeDescription ("content", @"A value associated with http-equiv or name depending on the context."), 
		    new TAttributeDescription ("contenteditable", @"Indicates whether the element's content is editable."), 
		    new TAttributeDescription ("contextmenu", @"Defines the ID of a <menu> element which will serve as the element's context menu."), 
		    new TAttributeDescription ("controls", @"Indicates whether the browser should show playback controls to the user."), 
		    new TAttributeDescription ("coords", @"A set of values specifying the coordinates of the hot-spot region."), 
		    new TAttributeDescription ("data", @"Specifies the URL of the resource."), 
		    new TAttributeDescription ("data-custom", @"lets you attach custom attribute to html elements."), 
		    new TAttributeDescription ("datetime", @"Indicates the date and time associated with the element."), 
		    new TAttributeDescription ("default", @"Indicates that the track should be enabled unless the user's preferences indicate something different."), 
		    new TAttributeDescription ("defer", @"Indicates that the script should be executed after the page has been parsed."), 
		    new TAttributeDescription ("dir", @"Defines the text direction. Allowed values are ltr (Left-To-Right) or rtl (Right-To-Left)"), 
		    new TAttributeDescription ("dirname", @""), 
		    new TAttributeDescription ("disabled", @"Indicates whether the user can interact with the element."), 
		    new TAttributeDescription ("download", @"Indicates that the hyperlink is to be used for downloading a resource."), 
		    new TAttributeDescription ("draggable", @"Defines whether the element can be dragged."), 
		    new TAttributeDescription ("dropzone", @"Indicates that the element accept the dropping of content on it."), 
		    new TAttributeDescription ("enctype", @"Defines the content type of the form date when the method is POST."), 
		    new TAttributeDescription ("for", @"Describes elements which belongs to this one."), 
		    new TAttributeDescription ("form", @"Indicates the form that is the owner of the element."), 
		    new TAttributeDescription ("headers", @"IDs of the <th> elements which applies to this element."), 
		    new TAttributeDescription ("height", @"Note: In some instances, such as <div>, this is a legacy attribute, in which case the CSS height property should be used instead. In other cases, such as <canvas>, the height must be specified with this attribute."), 
		    new TAttributeDescription ("hidden", @"Indicates the relevance of an element."), 
		    new TAttributeDescription ("high", @"Indicates the lower bound of the upper range."), 
		    new TAttributeDescription ("href", @"The URL of a linked resource."), 
		    new TAttributeDescription ("hreflang", @"Specifies the language of the linked resource."), 
		    new TAttributeDescription ("http-equiv", @""), 
		    new TAttributeDescription ("icon", @"Specifies a picture which represents the command."), 
		    new TAttributeDescription ("id", @"Often used with CSS to style a specific element. The value of this attribute must be unique."), 
		    new TAttributeDescription ("ismap", @"Indicatesthat the image is part of a server-side image map."), 
		    new TAttributeDescription ("itemprop", @""), 
		    new TAttributeDescription ("keytype", @"Specifies the type of key generated."), 
		    new TAttributeDescription ("kind", @"Specifies the kind of text track."), 
		    new TAttributeDescription ("label", @"Specifies a user-readable title of the text track."), 
		    new TAttributeDescription ("lang", @"Defines the language used in the element."), 
		    new TAttributeDescription ("language", @"Defines the script language used in the element."), 
		    new TAttributeDescription ("list", @"Identifies a list of pre-defined options to suggest to the user."), 
		    new TAttributeDescription ("loop", @"Indicates whether the media should start playing from the start when it's finished."), 
		    new TAttributeDescription ("low", @"Indicates the upper bound of the lower range."), 
		    new TAttributeDescription ("manifest", @"Specifies the URL of the document's cache manifest."), 
		    new TAttributeDescription ("max", @"Indicates the maximum value allowed."), 
		    new TAttributeDescription ("maxlength", @"Defines the maximum number of characters allowed in the element."), 
		    new TAttributeDescription ("media", @"Specifies a hint of the media for which the linked resource was designed."), 
		    new TAttributeDescription ("method", @"Defines which HTTP method to use when submitting the form. Can be GET (default) or POST."), 
		    new TAttributeDescription ("min", @"Indicates the minimum value allowed."), 
		    new TAttributeDescription ("multiple", @"Indicates whether multiple values can be entered in an input of the type email or file."), 
		    new TAttributeDescription ("name", @"Name of the element. For example used by the server to identify the fields in form submits."), 
		    new TAttributeDescription ("novalidate", @"This attribute indicates that the form shouldn't be validated when submitted."), 
		    new TAttributeDescription ("open", @"Indicates whether the details will be shown on page load."), 
		    new TAttributeDescription ("optimum", @"Indicates the optimal numeric value."), 
		    new TAttributeDescription ("pattern", @"Defines a regular expression which the element's value will be validated against."), 
		    new TAttributeDescription ("ping", @""), 
		    new TAttributeDescription ("placeholder", @"Provides a hint to the user of what can be entered in the field."), 
		    new TAttributeDescription ("poster", @"A URL indicating a poster frame to show until the user plays or seeks."), 
		    new TAttributeDescription ("preload", @"Indicates whether the whole resource, parts of it or nothing should be preloaded."), 
		    new TAttributeDescription ("pubdate", @"Indicates whether this date and time is the date of the nearest <article> ancestor element."), 
		    new TAttributeDescription ("radiogroup", @""), 
		    new TAttributeDescription ("readonly", @"Indicates whether the element can be edited."), 
		    new TAttributeDescription ("rel", @"Specifies the relationship of the target object to the link object."), 
		    new TAttributeDescription ("required", @"Indicates whether this element is required to fill out or not."), 
		    new TAttributeDescription ("reversed", @"Indicates whether the list should be displayed in a descending order instead of a ascending."), 
		    new TAttributeDescription ("rows", @"Defines the number of rows in a textarea."), 
		    new TAttributeDescription ("rowspan", @"Defines the number of rows a table cell should span over."), 
		    new TAttributeDescription ("sandbox", @""), 
		    new TAttributeDescription ("spellcheck", @"Indicates whether spell checking is allowed for the element."), 
		    new TAttributeDescription ("scope", @""), 
		    new TAttributeDescription ("scoped", @""), 
		    new TAttributeDescription ("seamless", @""), 
		    new TAttributeDescription ("selected", @"Defines a value which will be selected on page load."), 
		    new TAttributeDescription ("shape", @""), 
		    new TAttributeDescription ("size", @"Defines the width of the element (in pixels). If the element's type attribute is text or password then it's the number of characters."), 
		    new TAttributeDescription ("sizes", @""), 
		    new TAttributeDescription ("span", @""), 
		    new TAttributeDescription ("src", @"The URL of the embeddable content."), 
		    new TAttributeDescription ("srcdoc", @""), 
		    new TAttributeDescription ("srclang", @""), 
		    new TAttributeDescription ("start", @"Defines the first number if other than 1."), 
		    new TAttributeDescription ("step", @""), 
		    new TAttributeDescription ("style", @"Defines CSS styles which will override styles previously set."), 
		    new TAttributeDescription ("summary", @""), 
		    new TAttributeDescription ("tabindex", @"Overrides the browser's default tab order and follows the one specified instead."), 
		    new TAttributeDescription ("target", @""), 
		    new TAttributeDescription ("title", @"Text to be displayed in a tooltip when hovering over the element."), 
		    new TAttributeDescription ("type", @"Defines the type of the element."), 
		    new TAttributeDescription ("usemap", @""), 
		    new TAttributeDescription ("value", @"Defines a default value which will be displayed in the element on page load."), 
		    new TAttributeDescription ("width", @"Note: In some instances, such as <div>, this is a legacy attribute, in which case the CSS width property should be used instead. In other cases, such as <canvas>, the width must be specified with this attribute."), 
		    new TAttributeDescription ("wrap", @"Indicates whether the text should be wrapped.")
          };

        static TElementWithCustomAttributes[] ElementsWithCustomAttributes = new[]
        {
		    new TElementWithCustomAttributes ("form",new string[] {"accept","accept-charset","action","autocomplete","enctype","method","name","novalidate","target"}), 
		    new TElementWithCustomAttributes ("input",new string[] {"accept","alt","autocomplete","autofocus","checked","dirname","disabled","form","height","list","max","maxlength","min","multiple","name","pattern","placeholder","readonly","required","size","src","step","type","usemap","value","width"}), 		
		    new TElementWithCustomAttributes ("applet",new string[] {"align","alt","code","codebase"}), 
		    new TElementWithCustomAttributes ("caption",new string[] {"align"}), 
		    new TElementWithCustomAttributes ("col",new string[] {"align","span"}), 
		    new TElementWithCustomAttributes ("colgroup",new string[] {"align","span"}), 
		    new TElementWithCustomAttributes ("hr",new string[] {"align"}), 
		    new TElementWithCustomAttributes ("iframe",new string[] {"align","height","name","sandbox","seamless","src","srcdoc","width"}), 
		    new TElementWithCustomAttributes ("img",new string[] {"align","alt","height","ismap","src","usemap","width"}), 
		    new TElementWithCustomAttributes ("table",new string[] {"align","summary"}), 
		    new TElementWithCustomAttributes ("tbody",new string[] {"align"}), 
		    new TElementWithCustomAttributes ("td",new string[] {"align","colspan","headers","rowspan"}), 
		    new TElementWithCustomAttributes ("tfoot",new string[] {"align"}), 
		    new TElementWithCustomAttributes ("th",new string[] {"align","colspan","headers","rowspan","scope"}), 
		    new TElementWithCustomAttributes ("thead",new string[] {"align"}), 
		    new TElementWithCustomAttributes ("tr",new string[] {"align"}), 
		    new TElementWithCustomAttributes ("area",new string[] {"alt","coords","download","href","hreflang","media","ping","rel","shape","target"}), 
		    new TElementWithCustomAttributes ("script",new string[] {"async","charset","defer","language","src","type"}), 
		    new TElementWithCustomAttributes ("button",new string[] {"autofocus","disabled","form","name","type","value"}), 
		    new TElementWithCustomAttributes ("keygen",new string[] {"autofocus","challenge","disabled","form","keytype","name"}), 
		    new TElementWithCustomAttributes ("select",new string[] {"autofocus","disabled","form","multiple","name","required","size"}), 
		    new TElementWithCustomAttributes ("textarea",new string[] {"autofocus","cols","dirname","disabled","form","maxlength","name","placeholder","readonly","required","rows","wrap"}), 
		    new TElementWithCustomAttributes ("audio",new string[] {"autoplay","buffered","controls","loop","preload","src"}), 
		    new TElementWithCustomAttributes ("video",new string[] {"autoplay","buffered","controls","height","loop","poster","preload","src","width"}), 
		    new TElementWithCustomAttributes ("meta",new string[] {"charset","content","http-equiv","name"}), 
		    new TElementWithCustomAttributes ("command",new string[] {"checked","disabled","icon","radiogroup","type"}), 
		    new TElementWithCustomAttributes ("blockquote",new string[] {"cite"}), 
		    new TElementWithCustomAttributes ("del",new string[] {"cite","datetime"}), 
		    new TElementWithCustomAttributes ("ins",new string[] {"cite","datetime"}), 
		    new TElementWithCustomAttributes ("q",new string[] {"cite"}), 
		    new TElementWithCustomAttributes ("object",new string[] {"data","form","height","name","type","usemap","width"}), 
		    new TElementWithCustomAttributes ("time",new string[] {"datetime","pubdate"}), 
		    new TElementWithCustomAttributes ("track",new string[] {"default","kind","label","src","srclang"}), 
		    new TElementWithCustomAttributes ("fieldset",new string[] {"disabled","form","name"}), 
		    new TElementWithCustomAttributes ("optgroup",new string[] {"disabled"}), 
		    new TElementWithCustomAttributes ("option",new string[] {"disabled","selected","value"}), 
		    new TElementWithCustomAttributes ("a",new string[] {"download","href","hreflang","media","ping","rel","shape","target"}), 
		    new TElementWithCustomAttributes ("label",new string[] {"for","form"}), 
		    new TElementWithCustomAttributes ("output",new string[] {"for","form","name"}), 
		    new TElementWithCustomAttributes ("meter",new string[] {"form","high","low","max","min","optimum","value"}), 
		    new TElementWithCustomAttributes ("progress",new string[] {"form","max","value"}), 
		    new TElementWithCustomAttributes ("canvas",new string[] {"height","width"}), 
		    new TElementWithCustomAttributes ("embed",new string[] {"height","src","type","width"}), 
		    new TElementWithCustomAttributes ("base",new string[] {"href","target"}), 
		    new TElementWithCustomAttributes ("link",new string[] {"href","hreflang","media","rel","sizes","type"}), 
		    new TElementWithCustomAttributes ("bgsound",new string[] {"loop"}), 
		    new TElementWithCustomAttributes ("marquee",new string[] {"loop"}), 
		    new TElementWithCustomAttributes ("html",new string[] {"manifest"}), 
		    new TElementWithCustomAttributes ("source",new string[] {"media","src","type"}), 
		    new TElementWithCustomAttributes ("style",new string[] {"media","scoped","type"}), 
		    new TElementWithCustomAttributes ("map",new string[] {"name"}), 
		    new TElementWithCustomAttributes ("param",new string[] {"name","value"}), 
		    new TElementWithCustomAttributes ("details",new string[] {"open"}), 
		    new TElementWithCustomAttributes ("ol",new string[] {"reversed","start"}), 
		    new TElementWithCustomAttributes ("menu",new string[] {"type"}), 
		    new TElementWithCustomAttributes ("li",new string[] {"value"})
	    };

        static string ReplaceAttributeName (string a)
        {
            if (a == "class") return "css";
            if (a == "object") return "@object";
            if (a == "checked") return "@checked";
            if (a == "readonly") return "@readonly";
            if (a == "default") return "@default";
            if (a == "for") return "@for";
            if (a == "http-equiv") return "http_equiv";
            if (a == "accept-charset") return "accept_charset";
            if (a == "data-custom") return "data_custom";
            return a;
        }

        static string ReplaceElementName (string a)
        {
            if (a == "base") return "@base";
            if (a == "object") return "@object";
            return a;
        }

        static string ReplaceInterfaceName (string a)
        {
            return "I" + a.Replace ("-", "_") + "Attribute";
        }

        static TElementInfo[] elementInfos;

        static public TElementInfo[] GetElementInfos ()
        {
            if (elementInfos == null)
                elementInfos = 
                    (
                    from e in ElementDescriptions
                    let ea = ElementsWithCustomAttributes.SingleOrDefault (x => x.Name == e.Name) // n squared efficiency should really lookup
                    let theAttributes = ea == null ? new string[0] : ea.Attributes
                    let interfaceNames = theAttributes.Select (a => ReplaceInterfaceName (a))
                    select new TElementInfo
                    {
                        Name = e.Name,
                        Attributes = theAttributes,
                        SafeName = ReplaceElementName (e.Name),   
                        ImplementedInterfaces = !theAttributes.Any () ? "" : ", " + string.Join (", ", interfaceNames),
                        Summary = e.Description
                    }
                    ).ToArray();

            return elementInfos;
        }

        static TAttributeInfo[] attributeInfos;

        static public TAttributeInfo[] GetAttributeInfos ()
        {
            if (attributeInfos == null)
                attributeInfos = 
                (
                    from a in GetElementInfos ().SelectMany (e => e.Attributes).Distinct ().Concat (GlobalAttributes)
                    join ad in AttributeDescriptions on a equals ad.Name
                    let interfaceName = ReplaceInterfaceName (a)
                    let isGlobal = GlobalAttributes.Contains (a)
                    select new TAttributeInfo
                    {
                        Name = a,
                        SafeName = ReplaceAttributeName (a),
                        InterfaceName = interfaceName,
                        InterfaceNameWithComma = isGlobal ? "" : interfaceName + ", ",
                        Summary = ad.Description,
                        IsGlobal = isGlobal
                    }
                ).ToArray();

            return attributeInfos;
        }
    }
}
