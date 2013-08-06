using System;
using System.Collections.Generic;
using System.Linq;
using Hyperlinq;

namespace NancyHyperlinq
{
    public static class IndexView
    {
        public static object Index()
        {
            return "" +
                H.Doc(a => a.lang ("en"),
                    H.head (
                        H.meta (a => a.charset ("utf-8")),
                        H.title ("NancyHyperlinq"),
                        H.style (a => a.type ("text/css"), "body { text-align: center; }")
                    ),
                    H.body (
                        H.img (a => a.src ("/Content/nancy-logo.png").alt ("Nancy logo")),
                        H.br (),
                        "This view was rendered using Hyperlinq"
                    )
               );
        }
    }
}