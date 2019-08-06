using Medline.Recall.Core.SharedKernel;

namespace Medline.Recall.Core.Interfaces
{
    public interface IHandle<T> where T : BaseDomainEvent
    {
        void Handle(T domainEvent);
    }
}