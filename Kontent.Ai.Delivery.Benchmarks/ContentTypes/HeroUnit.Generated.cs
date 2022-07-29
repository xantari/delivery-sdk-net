// This code was generated by a kontent-generators-net tool 
// (see https://github.com/kontent-ai/model-generator-net).
// 
// Changes to this file may cause incorrect behavior and will be lost if the code is regenerated. 
// For further modifications of the class, create a separate file with the partial class.

using System.Collections.Generic;
using Kontent.Ai.Delivery.Abstractions;

namespace Kontent.Ai.Delivery.Benchmarks.ContentTypes
{
    public partial class HeroUnit
    {
        public const string Codename = "hero_unit";
        public const string ImageCodename = "image";
        public const string MarketingMessageCodename = "marketing_message";
        public const string SitemapCodename = "sitemap";
        public const string TitleCodename = "title";

        public IEnumerable<IAsset> Image { get; set; }
        public string MarketingMessage { get; set; }
        public IEnumerable<ITaxonomyTerm> Sitemap { get; set; }
        public IContentItemSystemAttributes System { get; set; }
        public string Title { get; set; }
    }
}