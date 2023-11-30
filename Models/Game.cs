using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PropertyEditors.ValueConverters;

namespace MetarankingsUmbraco.Models
{
    [PublishedModel("game")]
    public class Game : PublishedContentModel
    {
        public Game(IPublishedContent content, IPublishedValueFallback publishedValueFallback) : base(content, publishedValueFallback)
        {
        }
        public string Title => this.Value<string>("title");
        public string ImageUrl => this.GetCropUrl("image", "croppedHeight281");
        public float MiddleScore => this.Value<float>("middleScore");
        public short ScoresCount => this.Value<short>("scoresCount");
        public string Developer => this.Value<string>("developer");
        public string Publisher => this.Value<string>("publisher");
        public IEnumerable<string> Platforms => this.Value<IEnumerable<string>>("platforms");
        public IEnumerable<string> Genres => this.Value<IEnumerable<string>>("genres");
        public string Localization => this.Value<string>("localization");
        public DateTime ReleaseDate => this.Value<DateTime>("releaseDate");
        public string DescriptionTitle => this.Value<string>("descriptionTitle");
        public string DescriptionText => this.Value<string>("descriptionText");
    }
}
