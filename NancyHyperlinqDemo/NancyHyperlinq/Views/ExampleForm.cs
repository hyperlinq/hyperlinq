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
                H.div(
                    H.p("Form entry: "),
                    StandardForm(() => PostExampleForm(null), new[]
                    {
	                    new TextInput (() => model.Cat),
	                    new TextInput (() => model.Dog)
                    })
                ); 
        }

        public object PostExampleForm(ZooModel model)
        {
            return "" + MasterPage("Hey", new[]
                {
                    H.p("You posted the following values: "), H.p(model.Cat), H.p(model.Dog),
                    H.A("/", "Back Home")
                });
        }
    }

    public class ZooModel
    {
        public string Cat { get; set; }
        public string Dog { get; set; }
    }
}