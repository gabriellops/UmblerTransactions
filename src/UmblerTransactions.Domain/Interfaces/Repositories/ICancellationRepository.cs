using UmblerTransactions.Domain.Entities;

namespace UmblerTransactions.Domain.Interfaces.Repositories
{
    public interface ICancellationRepository
    {
        Task<CancellationEntity> EditAsync(Guid paymentId);
    }
}
