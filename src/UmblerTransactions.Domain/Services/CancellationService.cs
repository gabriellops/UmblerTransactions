using UmblerTransactions.Domain.Entities;
using UmblerTransactions.Domain.Interfaces.Repositories;
using UmblerTransactions.Domain.Interfaces.Services;

namespace UmblerTransactions.Domain.Services
{
    public class CancellationService : ICancellationService
    {
        private readonly ICancellationRepository _repository;

        public CancellationService(ICancellationRepository repository)
        {
            _repository = repository;
        }

        public async Task<CancellationEntity> Edit(Guid paymentId)
        {
            return await _repository.EditAsync(paymentId);
        }
    }
}
