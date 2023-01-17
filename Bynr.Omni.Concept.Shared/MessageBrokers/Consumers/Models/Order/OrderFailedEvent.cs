using Bynr.Omni.Concept.Core.MessageBrokers.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bynr.Omni.Concept.Shared.MessageBrokers.Consumers.Models.Order
{
    public class OrderFailedEvent : EventModel
    {
        public int OrderId { get; set; }
    }
}
