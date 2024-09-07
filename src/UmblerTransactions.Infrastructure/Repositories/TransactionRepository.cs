using UmblerTransactions.Domain.Contracts.Requests;
using UmblerTransactions.Domain.Entities;
using UmblerTransactions.Domain.Interfaces.Repositories;

namespace UmblerTransactions.Infrastructure.Repositories
{
    public class TransactionRepository : BaseApiRepository, ITransactionRepository
    {
        public TransactionRepository(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<TransactionEntity> AddAsync(TransactionRequest transaction)
        {
            return await PostAsJsonAsync<TransactionEntity>($"/1/sales/", transaction);
        }
    }
}
