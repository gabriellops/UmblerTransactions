using UmblerTransactions.Domain.Entities;

namespace UmblerTransactions.Domain.Interfaces.Repositories
{
    public interface ICaptureRepository
    {
        Task<CaptureEntity> EditAsync(Guid paymentId);
    }
}
