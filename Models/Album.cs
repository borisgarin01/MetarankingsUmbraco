using Umbraco.Cms.Core.Models.PublishedContent;

namespace MetarankingsUmbraco.Models
{
    [PublishedModel(contentTypeAlias: "album")]
    public class Album : PublishedContentModel
    {
        public Album(IPublishedContent content, IPublishedValueFallback publishedValueFallback) : base(content, publishedValueFallback)
        {
        }

        public string Title => this.Value<string>("title");
    }
}
