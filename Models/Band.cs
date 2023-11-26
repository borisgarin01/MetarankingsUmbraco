using Umbraco.Cms.Core.Models.PublishedContent;

namespace MetarankingsUmbraco.Models
{
	[PublishedModel(contentTypeAlias: "band")]
	public class Band : PublishedContentModel
	{
		public Band(IPublishedContent content, IPublishedValueFallback publishedValueFallback) : base(content, publishedValueFallback)
		{
		}

		public string BandName => this.Value<string>("bandName");
	}
}
