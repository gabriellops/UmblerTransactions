using UmblerTransactions.Domain.Entities;

namespace UmblerTransactions.Domain.Interfaces.Repositories
{
    public interface IConsultationRepository
    {
        Task<ConsultationEntity> GetByMerchantOrderIdAsync();
    }
}
