using Bynr.Omni.Concept.Core.MessageBrokers.Models;
using System.Threading.Tasks;

namespace Bynr.Omni.Concept.Core.MessageBrokers.Abstract
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="TEvent"></typeparam>
    public interface IEventHandler<in TEvent> where TEvent : EventModel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="event"></param>
        /// <returns></returns>
        Task Consume(TEvent @event);
    }
}
