using System.ComponentModel.DataAnnotations;

namespace UmblerTransactions.Domain.Contracts.Requests
{
    public class CancellationRequest
    {
        [Required(ErrorMessage = "Informe o 'id' do pagamento no formato exemplificado.")]
        public Guid Id { get; set; }
    }
}
