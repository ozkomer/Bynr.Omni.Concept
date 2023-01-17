using Bynr.Omni.Concept.Core.MessageBrokers.Models;

namespace Bynr.Omni.Concept.Shared.MessageBrokers.Consumers.Models.Stock
{
    public class UpdateStockEvent : EventModel
    {
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public int OrderId { get; set; }
    }
}
