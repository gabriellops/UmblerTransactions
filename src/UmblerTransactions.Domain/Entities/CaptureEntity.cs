using System.Text.Json.Serialization;

namespace UmblerTransactions.Domain.Entities
{
    public class CaptureEntity
    {
        [JsonPropertyName("Status")]
        public long Status { get; set; }

        [JsonPropertyName("Tid")]
        public string Tid { get; set; }

        [JsonPropertyName("ProofOfSale")]
        public long ProofOfSale { get; set; }

        [JsonPropertyName("AuthorizationCode")]
        public long AuthorizationCode { get; set; }

        [JsonPropertyName("ReturnCode")]
        public long ReturnCode { get; set; }

        [JsonPropertyName("ReturnMessage")]
        public string ReturnMessage { get; set; }

        [JsonPropertyName("Links")]
        public List<LinkEntity> Links { get; set; }
    }
}
