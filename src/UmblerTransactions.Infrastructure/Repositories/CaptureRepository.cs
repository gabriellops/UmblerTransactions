using UmblerTransactions.Domain.Entities;
using UmblerTransactions.Domain.Interfaces.Repositories;

namespace UmblerTransactions.Infrastructure.Repositories
{
    public class CaptureRepository : BaseApiRepository, ICaptureRepository
    {
        public CaptureRepository(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<CaptureEntity> EditAsync(Guid paymentId)
        {
            return await PutAsync<CaptureEntity>($"/1/sales/{paymentId}/capture");
        }
    }
}
