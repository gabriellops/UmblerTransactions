using UmblerTransactions.Domain.Contracts.Requests;
using UmblerTransactions.Domain.Entities;

namespace UmblerTransactions.Domain.Interfaces.Services
{
    public interface ITransactionService
    {
        Task<TransactionEntity> Add(TransactionRequest transaction);
    }
}
