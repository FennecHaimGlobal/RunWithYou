using System.Web;
using System.Web.Optimization;

namespace RunWithYou
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Script
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.1.0.min.js",
                        "~/Scripts/jquery-ui.min.js",
                        "~/Scripts/Skate/allinone_carousel.js",
                        "~/Scripts/Skate/owl.carousel.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jskate").Include(
                       "~/Scripts/Skate/fwslider.js"));

            bundles.Add(new ScriptBundle("~/bundles/jbootstrap").Include(
                     "~/Scripts/bootstrap.js",
                     "~/Scripts/bootstrap-datepicker.js",
                     "~/Scripts/bootstrap-datepicker.min.js",
                     "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                      "~/Scripts/modernizr-*"));

            //CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/Site.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/jquery-ui.min.css",
                      "~/Content/jquery-ui.structure.css",
                      "~/Content/jquery-ui.structure.min.css",
                      "~/Content/jquery-ui.theme.css",
                      "~/Content/jquery-ui.theme.min.css"));

            bundles.Add(new StyleBundle("~/Content/skate/css").Include(
                     "~/Content/Skate/allinone_carousel.css",
                      "~/Content/Skate/fwslider.css",
                      "~/Content/Skate/jquery.fancybox.css",
                      "~/Content/Skate/owl.carousel.css",
                      "~/Content/Skate/Social.css",
                      "~/Content/Skate/style.css"));

            bundles.Add(new StyleBundle("~/Content/bootstrap/css").Include(
                     "~/Content/bootstrap.min.css",
                     "~/Content/bootstrap-datepicker.css",
                     "~/Content/bootstrap-datepicker.min.css"));

           
        }
    }
}
