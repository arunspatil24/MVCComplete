using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace _12BuldingAndModification.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundle(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/script")
                .Include("~/scripts/jquery-1.10.2.js")
                .Include("~/scripts/bootstrap.js")
                .Include("~/scripts/modernizr-2.6.2.js")
                .Include("~/scripts/demo1.js")
                .Include("~/scripts/demo2.js"));

            bundles.Add(new StyleBundle("~/style")
                .Include("~/content/bootstrap.css")
                .Include("~/content/site.css")
                .Include("~/content/demo1.css")
                .Include("~/content/demo2.css"));
            BundleTable.EnableOptimizations = true;
        }
    }
}