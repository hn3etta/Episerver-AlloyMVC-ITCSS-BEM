using System.Web.Optimization;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace AlloyMVC_ITCSS_BEM.Business.Initialization
{
    [InitializableModule]
    public class BundleConfig : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            if (context.HostType == HostType.WebApplication)
            {
                RegisterBundles(BundleTable.Bundles);
            }
        }

        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                        "~/Static/js/jquery.js", //jquery.js can be removed and linked from CDN instead, we use a local one for demo purposes without internet connectionzz
                        "~/Static/js/bootstrap.js"));

            bundles.Add(new StyleBundle("~/bundles/css")
                .Include("~/Static/css/3rd-party/bootstrap.css", new CssRewriteUrlTransform())
                .Include("~/Static/css/3rd-party/bootstrap-responsive.css")
                .Include("~/Static/css/media.css")
                .Include("~/Static/css/style.css", new CssRewriteUrlTransform())
                .Include("~/Static/css/editmode.css")
                .Include("~/Static/css/core/3_generic/generic.normalize.css")
                .Include("~/Static/css/core/4_elements/elements.body.css")
                .Include("~/Static/css/core/4_elements/elements.headings.css")
                .Include("~/Static/css/core/5_objects/objects.containers.css")
                .Include("~/Static/css/core/6_components/blocks/ButtonBlock.css")
                .Include("~/Static/css/core/6_components/blocks/ContactBlock.css")
                .Include("~/Static/css/core/6_components/blocks/EditorialBlock.css")
                .Include("~/Static/css/core/6_components/blocks/FormBlock.css")
                .Include("~/Static/css/core/6_components/blocks/TeaserBlock.css")
                .Include("~/Static/css/core/6_components/blocks/JumbotronBlock.css")
                .Include("~/Static/css/core/7_trumps/TeaserBlock.css"));
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        public void Preload(string[] parameters)
        {
        }
    }
}
