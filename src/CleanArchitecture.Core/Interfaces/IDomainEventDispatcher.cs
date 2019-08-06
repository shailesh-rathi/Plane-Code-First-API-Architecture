using Medline.Recall.Core.SharedKernel;

namespace Medline.Recall.Core.Interfaces
{
    public interface IDomainEventDispatcher
    {
        void Dispatch(BaseDomainEvent domainEvent);
    }
}