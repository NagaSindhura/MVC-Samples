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

        public static MvcHtmlString DisplayMessage(this HtmlHelper html, string message)
        {
            string result = string.Format("This is the message: <p>{0}</p> ", message);

            return new MvcHtmlString(result);
        }

        public static string DisplayMessageStringFormat(this HtmlHelper html, string message)
        {
            //it alerts the view Engine that your content is not safe 
            //and should be encoded before it is added to the View
            return string.Format("This is the message: < p >{0}</ p >", message);
            //it causes to encode all of the contents of the content 
            //that is retured by the helper
            //p elemnt is encded as well which is not what we expect
        }

        public static MvcHtmlString DisplayMessageEncode(this HtmlHelper html, string message)
        {
            //More selective Encoding
            string encodedMessage = html.Encode(message);
            string result = String.Format("This is the message: <p>{0}</p>", encodedMessage);
            return new MvcHtmlString(result);
        }
    }
}