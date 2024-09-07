namespace UmblerTransactions.Domain.Contracts.Response
{
    public class CaptureResponse
    {
        public long Status { get; set; }
        public string Tid { get; set; }
        public long ProofOfSale { get; set; }
        public long AuthorizationCode { get; set; }
        public long ReturnCode { get; set; }
        public string ReturnMessage { get; set; }
    }
}
