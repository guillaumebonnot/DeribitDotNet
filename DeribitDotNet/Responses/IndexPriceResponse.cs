using Newtonsoft.Json;

namespace DeribitDotNet.Responses
{
    public class PriceIndex
    {
        [JsonProperty("estimated_delivery_price")]
        public double EstimatedDeliveryPrice;
        [JsonProperty("index_price")]
        public double IndexPrice;
    }

    public class IndexPriceResponse: Response
    {
        [JsonProperty("result")]
        public PriceIndex PriceIndex;
    }
}