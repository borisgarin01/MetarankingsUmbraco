using Microsoft.AspNetCore.Mvc.Routing;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors.ValueConverters;
using Umbraco.Cms.Core.Strings;
using Umbraco.Extensions;

namespace MetarankingsUmbraco.Models
{
    public class Song : PublishedContentModel
    {
        private IPublishedValueFallback _publishedValueFallback;

        public Song(IPublishedContent content, IPublishedValueFallback publishedValueFallback) : base(content, publishedValueFallback)
        {
            _publishedValueFallback = publishedValueFallback;
        }
        public string Title => this.Value<string>("title");
        public IHtmlEncodedString Lyrics => this.Value<IHtmlEncodedString>("lyrics");
        public string AudioRecord => this.Value<string>("audioRecord");
        public ImageCropperValue Logo => this.Value<ImageCropperValue>(_publishedValueFallback, "logo");
    }
}
