using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HarlemTech.Helpers
{
    public static class HtmlHelpers
    {
        public static string SanitizeWebsiteLink(this HtmlHelper html, string link)
        {
            if (!string.IsNullOrEmpty(link))
            {
                if (!link.StartsWith("http://"))
                {
                    return "http://" + link;
                }

                return link;
            }
            return "http://google.com";
        }
    }
}