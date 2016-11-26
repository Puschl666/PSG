Imports System.Web.Optimization

Public Module BundleConfig
    ' For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/javascript").Include(
                    "~/javascript/namespaces.js",
                    "~/javascript/jquery/jquery.js",
                    "~/javascript/jquery/jquery-ui.js",
                    "~/javascript/bootstrap.js",
                    "~/javascript/plugins/parallax.js",
                    "~/javascript/plugins/equalheight.js",
                    "~/javascript/general.js",
                    "~/javascript/javascript.js"))

        bundles.Add(New StyleBundle("~/css").Include(
                  "~/css/bootstrap.css",
                  "~/css/font-awesome.css",
                  "~/css/Common.css",
                  "~/css/Footer.css",
                  "~/css/Header.css",
                  "~/css/Navigation.css",
                  "~/css/SaleHierarchiest.css",
                  "~/css/Site.css",
                  "~/css/SubMenu.css",
                  "~/css/content/GameSelection.css",
                  "~/css/content/SiteHeadline.css"))
    End Sub
End Module

