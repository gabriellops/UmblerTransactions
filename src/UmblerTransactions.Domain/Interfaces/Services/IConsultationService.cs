using UmblerTransactions.Domain.Entities;

namespace UmblerTransactions.Domain.Interfaces.Services
{
    public interface IConsultationService
    {
        Task<ConsultationEntity> GetByMerchantOrderId();
    }
}
