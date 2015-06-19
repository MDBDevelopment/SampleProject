using System.Web;
using System.Web.Optimization;

namespace TechnicalTest
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-2.1.4.js",
                    "~/Scripts/jquery-ui-1.11.4.js",
                    "~/Scripts/jquery.validate.js",
                    "~/Scripts/jquery.validate.unobtrusive.js",
                    "~/Scripts/main.js"
                )
            );

            bundles.Add(new StyleBundle("~/css/layout_bundle").Include(
                "~/css/normalize.css",
                "~/css/main.css",
                "~/css/style.css"
                )
            );
        }
    }
}
