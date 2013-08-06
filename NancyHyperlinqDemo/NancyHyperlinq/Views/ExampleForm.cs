using System;
using System.Collections.Generic;
using System.Linq;
using Hyperlinq;

namespace NancyHyperlinq
{
    public partial class MainView
    {
        public object ExampleForm()
        {
            return ExampleForm(new ZooModel());
        }
         
        object ExampleForm (ZooModel model)
        {
            return "" +
                MasterPage ("Form Example",
                    new[] {
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

        public object PostExampleForm(ZooModel model)
        {
            return "" + MasterPage("Hey", new[]
                {
                    H.p("You posted the following values: "), H.p(model.Giraffe), H.p(model.Elephant),
                    H.A("/", "Back Home")
                });
        }
    }

    public class ZooModel
    {
        public string Giraffe { get; set; }
        public string Elephant { get; set; }
    }
}