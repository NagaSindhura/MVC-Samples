using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Infrastructure
{
    public static class CustomHelpers
    {
        public static MvcHtmlString ListArrayData(this HtmlHelper html, string[] items)
        {
            TagBuilder tagBuilder = new TagBuilder("ul");

            foreach (string item in items)
            {
                TagBuilder itemTagBuilder = new TagBuilder("li");
                itemTagBuilder.SetInnerText(item);
                tagBuilder.InnerHtml += itemTagBuilder.ToString();

            }

            return new MvcHtmlString(tagBuilder.ToString());
        }
    }
}