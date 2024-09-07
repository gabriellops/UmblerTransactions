using UmblerTransactions.Domain.Entities;
using UmblerTransactions.Domain.Interfaces.Repositories;
using UmblerTransactions.Domain.Interfaces.Services;

namespace UmblerTransactions.Domain.Services
{
    public class CaptureService : ICaptureService
    {
        private readonly ICaptureRepository _repository;

        public CaptureService(ICaptureRepository repository)
        {
            _repository = repository;
        }

        public async Task<CaptureEntity> Edit(Guid paymentId)
        {
            return await _repository.EditAsync(paymentId);
        }
    }
}
