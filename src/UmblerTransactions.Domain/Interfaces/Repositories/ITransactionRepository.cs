using UmblerTransactions.Domain.Contracts.Requests;
using UmblerTransactions.Domain.Entities;

namespace UmblerTransactions.Domain.Interfaces.Repositories
{
    public interface ITransactionRepository
    {
        Task<TransactionEntity> AddAsync(TransactionRequest transaction);
    }
}
