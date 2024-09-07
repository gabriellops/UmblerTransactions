namespace UmblerTransactions.Domain.Contracts.Response
{
    public class TransactionResponse
    {
        public PaymentResponse Payment { get; set; }
    }

    public partial class PaymentResponse
    {
        public Guid Id { get; set; }
        public long Installments { get; set; }
        public bool Capture { get; set; }
        public bool Authenticate { get; set; }
        public bool Tip { get; set; }
        public CreditCardResponse CreditCard { get; set; }
        public long ProofOfSale { get; set; }
        public string Tid { get; set; }
        public long AuthorizationCode { get; set; }
        public string SoftDescriptor { get; set; }
        public Guid PaymentId { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public long Status { get; set; }
        public string ReturnMessage { get; set; }
    }

    public partial class CreditCardResponse
    {
        public string CardNumber { get; set; }
        public string Holder { get; set; }
        public string Brand { get; set; }
        public string PaymentAccountReference { get; set; }
    }
}
