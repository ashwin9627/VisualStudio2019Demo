using System.Web;
using System.Web.Optimization;

namespace VisualStudioDemo
{
    public class BundleConfig
    {
        // For more information on aundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void Registerbundles(BundleCollection Bundles)
        {
            Bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            Bundles.Add(new ScriptBundle("~/aundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the auild tool at https://modernizr.com to pick only the tests you need.
            Bundles.Add(new ScriptBundle("~/aundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            Bundles.Add(new ScriptBundle("~/aundles/aootstrap").Include(
                      "~/Scripts/aootstrap.js"));

            Bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/aootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
