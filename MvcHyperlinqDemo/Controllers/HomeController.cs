using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Linq.Expressions;
using AttributeRouting.Web.Mvc;
using Hyperlinq;

namespace HyperlinqDemo.Controllers
{
    public class HomeController : Controller
    {
        [GET ("")]
        public ActionResult Index ()
        {
            return Content ("" + IndexView ());
        }

        HDoc IndexView ()
        {
            return
                MasterPage ("Hyperlinq", new[]
                    {
                        H.p ("This view was rendered using Hyperlinq"),
                        H.A (() => About(), "About"),
                        H.A (() => ExampleForm(), "Example Form")
                    }
                );
        }

        [GET("About")]
        public ActionResult About()
        {
            return Content ("" + AboutView ());
        }

        HDoc AboutView ()
        {
            return MasterPage ("About", new[] { H.p ("This one too."), H.A ("/", "Home") });
        }

        [GET("ExampleForm")]
        public ActionResult ExampleForm ()
        {
            return Content ("" + ExampleForm (new ZooModel ()));
        }

        HDoc ExampleForm (ZooModel model)
        {
            return
                MasterPage ("Form Example",
                    new[]
                    {
                        H.p("Form entry: "),
                        StandardForm(() => PostExampleForm(null), null, new[]
                            {
	                            new TextInput (() => model.Giraffe),
	                            new TextInput (() => model.Elephant)
                            }
                        )
                    }
                );
        }

        [POST("PostExampleForm")]
        public ActionResult PostExampleForm (ZooModel model)
        {
            return Content ("" + PostExampleFormView (model));
        }

        HDoc PostExampleFormView (ZooModel model)
        {
            return
                MasterPage ("Hey", new[]
                {
                    H.p("You posted the following values: "), H.p(model.Giraffe), H.p(model.Elephant),
                    H.A("/", "Back Home")
                });
        }

        HDoc MasterPage (string title, object body)
        {
            return
                H.Doc (a => a.lang ("en"),
                    H.head (
                        H.meta (a => a.charset ("utf-8")),
                        H.title (title),
                        H.link (a => a.rel ("stylesheet").href ("/content/site.css"))
                    ),
                    H.body (body)
               );
        }

        HElement StandardForm (Expression<Action> action, ChainFunc<HAttributes.form> extraAttributes, IEnumerable<HInput> inputs)
        {
            return
                H.form (a => a.method ("post")
                             .action (H.Url (action))
                             .Merge (extraAttributes),
                    H.table (
                       from input in inputs
                       select H.tr
                       (
                           H.td (input is HiddenInput ? null : H.label (a => a.@for (input.Id), input.Label)),
                           H.td (input.Render ())
                       )
                    ),
                    H.p (H.input (a => a.type ("submit").value ("OK")))
            );
        }
    }

    public class ZooModel
    {
        public string Giraffe { get; set; }
        public string Elephant { get; set; }
    }
}
