using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _05CustomeHTMLHelperMethod.MyHtmlHelpers
{
    public class CustumHelperMethod
    {
        public static IHtmlString File(string id)
        {
            TagBuilder tagBuilder = new TagBuilder("input");
            tagBuilder.Attributes.Add("type", "file");
            tagBuilder.Attributes.Add("id", id);
            return new MvcHtmlString(tagBuilder.ToString());
        }
    }
}