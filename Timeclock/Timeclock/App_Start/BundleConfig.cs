﻿using System.Web;
using System.Web.Optimization;

namespace Timeclock
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.8.2.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/jquery.blockui.js",
                      "~/Scripts/jquery.cookie.js",
                      "~/Scripts/jquery-ui-1.9.2.custom.min.js",
                      "~/Scripts/slimScroll.min.js",
                      "~/Scripts/fullcalendar.min.js",
                      "~/Scripts/jquery.uniform.min.js",
                      "~/Scripts/chosen.jquery.min.js",
                      "~/Scripts/jquery.fancybox.pack.js",
                      "~/Scripts/app.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                    //"~/Content/bootstrap.css",
                    "~/Content/bootstrap.min.css",
                    "~/Content/bootstrap-responsive.min.css",
                    "~/Content/font-awesome.min.css",
                    "~/Content/style.css",
                    "~/Content/style_responsive.css",
                    "~/Content/style_default.css",
                    "~/Content/jquery.fancybox.css",
                    //"~/Content/chosen.css",
                    "~/Content/uniform.default.css",                      
                    //"~/Content/bootstrap-fileupload.css",
                    "~/Content/bootstrap-fullcalendar.css"
                      ));
        }
    }
}
