
using UmblerTransactions.Domain.Entities;
using UmblerTransactions.Domain.Interfaces.Repositories;
using UmblerTransactions.Domain.Utils;

namespace UmblerTransactions.Infrastructure.Repositories
{
    public class ConsultationRepository : BaseApiRepository, IConsultationRepository
    {
        public ConsultationRepository(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task<ConsultationEntity> GetByMerchantOrderIdAsync()
        {
            return await GetAsync<ConsultationEntity>($"/1/sales?merchantOrderId={ConstantUtil.MerchantOrderId}");
        }
    }
}
