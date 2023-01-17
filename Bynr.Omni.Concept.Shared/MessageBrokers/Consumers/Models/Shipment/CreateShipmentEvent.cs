using Bynr.Omni.Concept.Core.MessageBrokers.Models;

namespace Bynr.Omni.Concept.Shared.MessageBrokers.Consumers.Models.Shipment
{
    public class CreateShipmentEvent : EventModel
    {
        public int OrderId { get; set; }

        public int ShipmentType { get; set; }
    }
}
