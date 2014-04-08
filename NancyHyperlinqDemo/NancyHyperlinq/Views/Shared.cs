using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Hyperlinq;

namespace NancyHyperlinq
{
    public partial class MainView
    {
        HDoc MasterPage (string title, object body)
        {
            return
                H.Doc(a => a.lang ("en"),
                    H.head (
                        H.meta (a => a.charset ("utf-8")),
                        H.title (title),
                        H.link (a => a.rel ("stylesheet").href ("/content/site.css"))
                    ),
                    H.body (body)
               );
        }

        HElement NancyLogo()
        {
            return H.img(a => a.src("/Content/nancy-logo.png").alt("Nancy logo"));
        }

        HElement StandardForm (Expression<Action> action, ChainFunc<HAttributes.form> extraAttributes, IEnumerable<HInput> inputs)
        {          
            return
                H.form(a => a.method("post")
                             .action(H.Url(action))  
                             .Merge (extraAttributes),
                    H.table(
                       from input in inputs
                       select H.tr
                       (
                           H.td(input is HiddenInput ? null : H.label(a => a.@for(input.Id), input.Label)),
                           H.td(input.Render())
                       )
                    ),
                    H.p (H.input(a => a.type("submit").value("OK")))
            );
        }
    }
}