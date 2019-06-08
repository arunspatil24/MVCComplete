using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05CustomeHTMLHelperMethod.MyHtmlHelpers
{
    public static class CustomeHelperExtensionMethod
    {
        public static IHtmlString File(this HtmlHelper htmlHelpers,string id)
        {
            TagBuilder tagBuilder = new TagBuilder("input");
            tagBuilder.Attributes.Add("type", "file");
            tagBuilder.Attributes.Add("id", id);
            return new MvcHtmlString(tagBuilder.ToString());
        }
    }
}