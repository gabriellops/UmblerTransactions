using UmblerTransactions.Domain.Entities;

namespace UmblerTransactions.Domain.Interfaces.Services
{
    public interface ICancellationService
    {
        Task<CancellationEntity> Edit(Guid paymentId);
    }
}
