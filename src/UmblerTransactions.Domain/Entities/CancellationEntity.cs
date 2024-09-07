using System.Text.Json.Serialization;

namespace UmblerTransactions.Domain.Entities
{
    public class CancellationEntity
    {
        [JsonPropertyName("Status")]
        public long Status { get; set; }

        [JsonPropertyName("Tid")]
        public string Tid { get; set; }

        [JsonPropertyName("ProofOfSale")]
        public long ProofOfSale { get; set; }

        [JsonPropertyName("AuthorizationCode")]
        public long AuthorizationCode { get; set; }

        [JsonPropertyName("ReasonCode")]
        public long ReasonCode { get; set; }

        [JsonPropertyName("ReasonMessage")]
        public string ReasonMessage { get; set; }

        [JsonPropertyName("ProviderReturnCode")]
        public long ProviderReturnCode { get; set; }

        [JsonPropertyName("ProviderReturnMessage")]
        public string ProviderReturnMessage { get; set; }

        [JsonPropertyName("ReturnCode")]
        public long ReturnCode { get; set; }

        [JsonPropertyName("ReturnMessage")]
        public string ReturnMessage { get; set; }

        [JsonPropertyName("Links")]
        public List<LinkEntity> Links { get; set; }
    }
}
