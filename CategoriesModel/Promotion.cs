namespace CategoriesModel
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int MinimumPhotoCount { get; set; }
        public double? OriginalPrice { get; set; }
        public bool? Recommended { get; set; }
    }
}