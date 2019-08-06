using Ardalis.GuardClauses;
using Medline.Recall.Core.Events;
using Medline.Recall.Core.Interfaces;

namespace Medline.Recall.Core.Services
{
    public class ToDoItemService : IHandle<ToDoItemCompletedEvent>
    {
        public void Handle(ToDoItemCompletedEvent domainEvent)
        {
            Guard.Against.Null(domainEvent, nameof(domainEvent));

            // Do Nothing
        }
    }
}
