using UmblerTransactions.Domain.Entities;
using UmblerTransactions.Domain.Interfaces.Repositories;
using UmblerTransactions.Domain.Interfaces.Services;

namespace UmblerTransactions.Domain.Services
{
    public class ConsultationService : IConsultationService
    {
        private readonly IConsultationRepository _repository;

        public ConsultationService(IConsultationRepository repository)
        {
            _repository = repository;
        }

        public async Task<ConsultationEntity> GetByMerchantOrderId()
        {
            return await _repository.GetByMerchantOrderIdAsync();
        }
    }
}
