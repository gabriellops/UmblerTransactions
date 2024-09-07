namespace UmblerTransactions.Domain.Contracts.Response
{
    public class CancellationResponse
    {
        public long Status { get; set; }
        public string Tid { get; set; }
        public long ProofOfSale { get; set; }
        public long AuthorizationCode { get; set; }
        public long ReasonCode { get; set; }
        public string ReasonMessage { get; set; }
        public long ReturnCode { get; set; }
        public string ReturnMessage { get; set; }
    }
}
