namespace CategoriesModel
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class ListingFeeTier
    {
        public int MinimumTierPrice { get; set; }
        public double FixedFee { get; set; }
    }
}