using System;
using System.Collections.Generic;
using System.Linq;
using Hyperlinq;

namespace NancyHyperlinq
{
    public partial class MainPresenter
    {
        HDoc MasterPage (string title, object body)
        {
            return
                H.Doc(a => a.lang ("en"),
                    H.head (
                        H.meta (a => a.charset ("utf-8")),
                        H.title (title),
                        H.style (a => a.type ("text/css"), "body { text-align: center; }")
                    ),
                    H.body (body)
               );
        }

        HElement NancyLogo()
        {
            return H.img(a => a.src("/Content/nancy-logo.png").alt("Nancy logo"));
        }
    }
}