using System.Web;
using System.Web.Optimization;

namespace Ducksociety
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                          "~/Scripts/jquery.prettyPhoto.js",
                            "~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.min.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content//font-awesome.min.css",
                        "~/Content//prettyPhoto.css",
                           "~/Content//animate.css",
                              "~/Content//main.css"));


        }
    }
}
