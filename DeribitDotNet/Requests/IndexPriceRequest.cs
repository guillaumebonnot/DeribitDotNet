using DeribitDotNet.Responses;
using Newtonsoft.Json;

namespace DeribitDotNet.Requests
{
    public class IndexPriceRequest : Request<IndexPriceResponse>
    {
        [JsonProperty("index_name")]
        public string Index;

        public IndexPriceRequest(string index) : base("get_index_price", true)
        {
            Index = index;
        }
    }
}