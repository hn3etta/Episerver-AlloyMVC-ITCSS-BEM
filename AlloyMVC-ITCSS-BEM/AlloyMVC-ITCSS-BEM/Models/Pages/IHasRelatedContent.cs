using EPiServer.Core;

namespace AlloyMVC_ITCSS_BEM.Models.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
