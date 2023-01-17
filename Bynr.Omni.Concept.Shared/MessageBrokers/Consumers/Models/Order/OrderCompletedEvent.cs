using Bynr.Omni.Concept.Core.MessageBrokers.Models;

namespace Bynr.Omni.Concept.Shared.MessageBrokers.Consumers.Models.Order
{
    public class OrderCompletedEvent : EventModel
    {
        public int OrderId { get; set; }
    }
}
