using UmblerTransactions.Domain.Entities;

namespace UmblerTransactions.Domain.Interfaces.Services
{
    public interface ICaptureService
    {
        Task<CaptureEntity> Edit(Guid paymentId);
    }
}
