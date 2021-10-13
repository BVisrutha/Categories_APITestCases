using CategoriesModel;
using FluentAssertions;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Linq;

namespace CategoriesAPITest
{
    public class Tests
    {
        private string url = "https://api.tmsandbox.co.nz/v1/Categories/6327/Details.json?catalogue=false";

        [Test]
        public void CategoryNameComparision()
        {
            var utilities = new Utilities();

            var response = utilities.GetJSONResponse(url);

            var category = string.IsNullOrWhiteSpace(response) ? new Category() : JsonConvert.DeserializeObject<Category>(response);

            category.Name.Should().BeEquivalentTo("Carbon credits");
        }

        [Test]
        public void CanRelistComparision()
        {
            var utilities = new Utilities();

            var response = utilities.GetJSONResponse(url);

            var category = string.IsNullOrWhiteSpace(response) ? new Category() : JsonConvert.DeserializeObject<Category>(response);

            category.CanRelist.Should().BeTrue();
        }

        [Test]
        public void DescriptionComparision()
        {
            var utilities = new Utilities();

            var response = utilities.GetJSONResponse(url);

            var category = string.IsNullOrWhiteSpace(response) ? new Category() : JsonConvert.DeserializeObject<Category>(response);

            var promotion = category?.Promotions?.First(c => c.Name=="Gallery");

            promotion.Description.Should().BeEquivalentTo("2x larger image");
        }
    }
}