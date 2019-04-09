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
                           "~/Scripts/fontawesome/all.js",
                           "~/Scripts/fontawesome/all.min.js",
                           "~/Scripts/fontawesome/brands.js",
                           "~/Scripts/fontawesome/brands.min.js",
                           "~/Scripts/fontawesome/fontawesome.js",
                           "~/Scripts/fontawesome/fontawesome.min.js",
                           "~/Scripts/fontawesome/regular.js",
                           "~/Scripts/fontawesome/regular.min.js",
                           "~/Scripts/fontawesome/solid.js",
                           "~/Scripts/fontawesome/solid.min.js",
                           "~/Scripts/fontawesome/v4-shims.js",
                           "~/Scripts/fontawesome/v4-shims.min.js",
                            "~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.min.js"));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/font-awesome.min.css",
                        "~/Content/prettyPhoto.css",
                           "~/Content/animate.css",
                             "~/Content/brands.css",
                               "~/Content/fontawesome-all.css",
                                 "~/Content/fontawesome-all.min.css",
                                    "~/Content/fontawesome.css",
                                      "~/Content/fontawesome.min.css",
                                        "~/Content/main.css",
                                          "~/Content/prettyPhoto.css",
                                            "~/Content/regular.css",
                                              "~/Content/regular.min.css",
                                                "~/Content/solid.css",
                                                  "~/Content/solid.min.css",
                                                    "~/Content/svg-with-js.css",
                                                      "~/Content/svg-with-js.min.css",
                                                        "~/Content/v4-shims.css",
                                                          "~/Content/v4-shims.min.css",
                                                                 "~/Content/main.css"));


        }
    }
}
