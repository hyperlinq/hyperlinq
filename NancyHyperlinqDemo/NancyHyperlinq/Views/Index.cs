using System;
using System.Collections.Generic;
using System.Linq;
using Hyperlinq;

namespace NancyHyperlinq
{
    public partial class MainPresenter
    {
        public object Index()
        {
            return "" +
                MasterPage ("Nancy Hyperlinq", new []
                    {
                        NancyLogo(),
                        H.p ("This view was rendered using Hyperlinq"),
                        H.A (() => About(), "About")
                    }
               );
        }
    }
}