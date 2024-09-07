using UmblerTransactions.Domain.Entities;
using UmblerTransactions.Domain.Interfaces.Repositories;

namespace UmblerTransactions.Infrastructure.Repositories
{
    public class CancellationRepository : BaseApiRepository, ICancellationRepository
    {
        public CancellationRepository(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<CancellationEntity> EditAsync(Guid paymentId)
        {
            return await PutAsync<CancellationEntity>($"/1/sales/{paymentId}/void");
        }
    }
}
