using Medline.Recall.Core.Entities;
using Medline.Recall.Core.SharedKernel;

namespace Medline.Recall.Core.Events
{
    public class ToDoItemCompletedEvent : BaseDomainEvent
    {
        public ToDoItem CompletedItem { get; set; }

        public ToDoItemCompletedEvent(ToDoItem completedItem)
        {
            CompletedItem = completedItem;
        }
    }
}