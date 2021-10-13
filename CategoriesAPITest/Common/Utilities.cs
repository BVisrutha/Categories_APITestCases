using RestSharp;

namespace CategoriesAPITest
{
    public class Utilities
    {
        /// <summary>
        /// Returns JSON Response from API endpoint
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string GetJSONResponse(string url)
        {
            var client = new RestClient(url);

            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Get(request);

            return response?.Content;
        }
    }
}