using System.Collections.Generic;

namespace CategoriesModel
{
    public class Category
    {
        public bool CanListAuctions { get; set; }
        public bool CanListClassifieds { get; set; }
        public bool CanRelist { get; set; }
        public bool CanUseCounterOffers { get; set; }
        public bool IsFreeToRelist { get; set; }
        public Fees Fees { get; set; }
        public int AreaOfBusiness { get; set; }
        public int CategoryId { get; set; }
        public int DefaultDuration { get; set; }
        public int DefaultRelistDuration { get; set; }
        public int FreePhotoCount { get; set; }
        public int MaximumPhotoCount { get; set; }
        public int MaximumTitleLength { get; set; }
        public List<int> AllowedDurations { get; set; }
        public List<object> EmbeddedContentOptions { get; set; }
        public List<Promotion> Promotions { get; set; }
        public string LegalNotice { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
    }
}