using Bynr.Omni.Concept.Core.Settings.Abstract;

namespace Bynr.Omni.Concept.Core.Settings.Concrete.MessageBrokers
{
    /// <summary>
    /// 
    /// </summary>
    public class EasyNetQSettings : ISettings
    {
        /// <summary>
        /// 
        /// </summary>
        public string Uri { get; set; }
    }
}
