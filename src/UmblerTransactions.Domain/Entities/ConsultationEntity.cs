using System.Text.Json.Serialization;

namespace UmblerTransactions.Domain.Entities
{
    public partial class ConsultationEntity
    {
        [JsonPropertyName("Payment")]
        public List<PaymentConsultationEntity> PaymentConsultationEntity { get; set; }
    }

    public partial class PaymentConsultationEntity
    {
        [JsonPropertyName("PaymentId")]
        public Guid PaymentId { get; set; }

        [JsonPropertyName("ReceveidDate")]
        public DateTime ReceveidDate { get; set; }
    }
}
