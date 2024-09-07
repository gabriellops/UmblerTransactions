using System.Text.Json.Serialization;

namespace UmblerTransactions.Domain.Entities
{
    public class TransactionEntity
    {
        [JsonPropertyName("MerchantOrderId")]
        public string MerchantOrderId { get; set; }

        [JsonPropertyName("Customer")]
        public CustomerEntity Customer { get; set; }

        [JsonPropertyName("Payment")]
        public PaymentEntity Payment { get; set; }
    }

    public partial class CustomerEntity
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }
        [JsonPropertyName("Identity")]
        public string Identity { get; set; }

        [JsonPropertyName("IdentityType")]
        public string IdentityType { get; set; }

        [JsonPropertyName("Email")]
        public string Email { get; set; }

        [JsonPropertyName("Birthdate")]
        public DateTime BirthDate { get; set; }

        [JsonPropertyName("Address")]
        public AddressEntity Address { get; set; }

        [JsonPropertyName("DeliveryAddress")]
        public AddressEntity DeliveryAddress { get; set; }

        [JsonPropertyName("Billing")]
        public AddressEntity Billing { get; set; }
    }

    public partial class AddressEntity
    {
        [JsonPropertyName("Street")]
        public string Street { get; set; }

        [JsonPropertyName("Number")]
        public string Number { get; set; }

        [JsonPropertyName("Complement")]
        public string Complement { get; set; }

        [JsonPropertyName("ZipCode")]
        public string ZipCode { get; set; }

        [JsonPropertyName("City")]
        public string City { get; set; }

        [JsonPropertyName("State")]
        public string State { get; set; }

        [JsonPropertyName("Country")]
        public string Country { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("Neighborhood")]
        public string Neighborhood { get; set; }
    }

    public partial class PaymentEntity
    {
        [JsonPropertyName("ServiceTaxAmount")]
        public long ServiceTaxAmount { get; set; }

        [JsonPropertyName("Installments")]
        public long Installments { get; set; }

        [JsonPropertyName("Interest")]
        public string Interest { get; set; }

        [JsonPropertyName("Capture")]
        public bool Capture { get; set; }

        [JsonPropertyName("Authenticate")]
        public bool Authenticate { get; set; }

        [JsonPropertyName("Tip")]
        public bool Tip { get; set; }

        [JsonPropertyName("CreditCard")]
        public CreditCardEntity CreditCard { get; set; }

        [JsonPropertyName("IsCryptoCurrencyNegotiation")]
        public bool IsCryptoCurrencyNegotiation { get; set; }

        [JsonPropertyName("TryAutomaticCancellation")]
        public bool TryAutomaticCancellation { get; set; }

        [JsonPropertyName("ProofOfSale")]
        public long ProofOfSale { get; set; }

        [JsonPropertyName("Tid")]
        public string Tid { get; set; }

        [JsonPropertyName("AuthorizationCode")]
        public long AuthorizationCode { get; set; }

        [JsonPropertyName("SoftDescriptor")]
        public string SoftDescriptor { get; set; }

        [JsonPropertyName("PaymentId")]
        public Guid PaymentId { get; set; }

        [JsonPropertyName("Type")]
        public string Type { get; set; }

        [JsonPropertyName("Amount")]
        public decimal Amount { get; set; }

        [JsonPropertyName("CapturedAmount")]
        public long CapturedAmount { get; set; }

        [JsonPropertyName("Country")]
        public string Country { get; set; }

        [JsonPropertyName("ExtraDataCollection")]
        public List<object> ExtraDataCollection { get; set; }

        [JsonPropertyName("Status")]
        public long Status { get; set; }

        [JsonPropertyName("ReturnCode")]
        public long ReturnCode { get; set; }

        [JsonPropertyName("ReturnMessage")]
        public string ReturnMessage { get; set; }

        [JsonPropertyName("MerchantAdviceCode")]
        public long MerchantAdviceCode { get; set; }

        [JsonPropertyName("Links")]
        public List<LinkEntity> Links { get; set; }
    }

    public partial class CreditCardEntity
    {
        [JsonPropertyName("CardNumber")]
        public string CardNumber { get; set; }

        [JsonPropertyName("Holder")]
        public string Holder { get; set; }

        [JsonPropertyName("ExpirationDate")]
        public string ExpirationDate { get; set; }

        [JsonPropertyName("SecurityCode")]
        public string SecurityCode { get; set; }

        [JsonPropertyName("SaveCard")]
        public bool SaveCard { get; set; }

        [JsonPropertyName("Brand")]
        public string Brand { get; set; }

        [JsonPropertyName("PaymentAccountReference")]
        public string PaymentAccountReference { get; set; }

        [JsonPropertyName("CardOnFile")]
        public CardOnFileEntity CardOnFile { get; set; }
    }

    public partial class CardOnFileEntity
    {
        [JsonPropertyName("Usage")]
        public string Usage { get; set; }

        [JsonPropertyName("Reason")]
        public string Reason { get; set; }
    }
    public partial class LinkEntity
    {
        [JsonPropertyName("Method")]
        public string Method { get; set; }

        [JsonPropertyName("Rel")]
        public string Rel { get; set; }

        [JsonPropertyName("Href")]
        public string Href { get; set; }
    }
}
