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
            var zoo = new ZooModel();

            return "" +
                H.div(
                    H.p("Form entry: "),
                    StandardForm(() => PostExampleForm(null), new[]
                    {
	                    new TextInput (() => zoo.Cat),
	                    new TextInput (() => zoo.Dog)
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