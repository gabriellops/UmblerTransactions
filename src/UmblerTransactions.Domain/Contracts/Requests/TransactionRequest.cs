using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using UmblerTransactions.Domain.Utils;

namespace UmblerTransactions.Domain.Contracts.Requests
{
    public class TransactionRequest
    {
        public string MerchantOrderId { get; set; } = ConstantUtil.MerchantOrderId;
        public CustomerRequest Customer { get; set; }
        public PaymentRequest Payment { get; set; }
    }

    public partial class CustomerRequest
    {
        [Required(ErrorMessage = "Informe o nome completo.")]
        [MinLength(7, ErrorMessage = "Nome deve conter no minimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "O nome deve conter no máximo {1} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Informe o email.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }

    public partial class PaymentRequest
    {
        [Required(ErrorMessage = "Informe o número de parcelas.")]
        public int Installments { get; set; } = 2;
        public CreditCardRequest CreditCard { get; set; }

        [Required(ErrorMessage = "Informe o valor do pedido.")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Informe somente números.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public decimal Amount { get; set; }
        public string Type { get; set; } 
        public bool Recurrent { get; set; }
        public InitiatedTransactionIndicatorRequest InitiatedTransactionIndicator { get; set; }
    }

    public partial class CreditCardRequest
    {
        [Required(ErrorMessage = "Informe o número do cartão.")]
        [RegularExpression(@"^\d{4}\d{4}\d{4}\d{4}$", ErrorMessage = "Informe os dígitos do cartão por espaços. Ex: 1234567890123456")]
        public string CardNumber { get; set; }

        [Required(ErrorMessage = "Informe o nome impresso no cartão.")]
        [MinLength(3, ErrorMessage = "Nome deve conter no minimo {1} caracteres")]
        [MaxLength(40, ErrorMessage = "O nome deve conter no máximo {1} caracteres.")]
        public string Holder { get; set; }

        [Required(ErrorMessage = "Informe a data de validade do cartão.")]
        [MaxLength(7)]
        public string ExpirationDate { get; set; }

        [Required(ErrorMessage = "Informe o código de segurança do cartão.")]
        [MaxLength(3)]
        public string SecurityCode { get; set; }
        public string Brand { get; set; }
    }

    public partial class InitiatedTransactionIndicatorRequest
    {
        public string Category { get; set; }
        public string Subcategory { get; set; }
    }
}
