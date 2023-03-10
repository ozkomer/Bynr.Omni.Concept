using MassTransit;
using Bynr.Omni.Concept.Core.MessageBrokers.Abstract;
using Bynr.Omni.Concept.Core.MessageBrokers.Models;
using System.Threading.Tasks;

namespace Bynr.Omni.Concept.Core.MessageBrokers.Concrete.RabbitMQ.MassTransit
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MassTransitAdapter<T> : IConsumer<T> where T : EventModel
    {
        private readonly IEventHandler<T> _eventHandler;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="eventHandler"></param>
        public MassTransitAdapter(IEventHandler<T> eventHandler)
        {
            _eventHandler = eventHandler;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Consume(ConsumeContext<T> context)
        {
            await _eventHandler.Consume(context.Message);
        }
    }
}
