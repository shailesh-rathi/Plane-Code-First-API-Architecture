using Medline.Recall.Core.Interfaces;
using Medline.Recall.Core.SharedKernel;

namespace Medline.Recall.Tests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public void Dispatch(BaseDomainEvent domainEvent) { }
    }
}
