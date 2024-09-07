using UmblerTransactions.Domain.Contracts.Requests;
using UmblerTransactions.Domain.Entities;
using UmblerTransactions.Domain.Interfaces.Repositories;
using UmblerTransactions.Domain.Interfaces.Services;

namespace UmblerTransactions.Domain.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _repository;

        public TransactionService(ITransactionRepository repository)
        {
            _repository = repository;
        }

        public async Task<TransactionEntity> Add(TransactionRequest transaction)
        {
            transaction.Payment.Type = "CreditCard";

            transaction.Payment.CreditCard.Brand = transaction.Payment.CreditCard.CardNumber[0] switch
            {
                '3' => "Amex",
                '5' => "Master",
                '6' => "Discover",
                _ => "Visa"
            };

            if (transaction.Payment.CreditCard.Brand == "Master")
            {
                transaction.Payment.InitiatedTransactionIndicator.Category = "C1";
                transaction.Payment.InitiatedTransactionIndicator.Subcategory = "Installment";
            }

            if (transaction.Payment.Installments > 1)
                transaction.Payment.Recurrent = false;

            return await _repository.AddAsync(transaction);
        }
    }
}
