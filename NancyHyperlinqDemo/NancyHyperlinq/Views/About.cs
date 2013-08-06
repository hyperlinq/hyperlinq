using System;
using System.Collections.Generic;
using System.Linq;
using Hyperlinq;

namespace NancyHyperlinq
{
    public partial class MainView
    {
        public object About()
        {
            return "" + MasterPage ("About", new[] { NancyLogo(), H.p("This one too."), H.A ("/", "Home") } );
        }
    }
}