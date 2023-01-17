using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Bynr.Omni.Concept.Core.Mappings.Abstract;
using Bynr.Omni.Concept.Core.Mappings.Concrete.Mapster;
using Bynr.Omni.Concept.Core.MessageBrokers.Abstract;
using Bynr.Omni.Concept.Core.MessageBrokers.Concrete.RabbitMQ.MassTransit;
using Bynr.Omni.Concept.Core.Settings.Concrete;

namespace Bynr.Omni.Concept.Core.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public static class RegisterCoreExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddCore(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IMapping, MapsterMapping>();

            var massTransitSettings = new MassTransitSettings();
            configuration.GetSection(nameof(MassTransitSettings)).Bind(massTransitSettings);
            services.Configure<MassTransitSettings>(configuration.GetSection(nameof(MassTransitSettings)));
            services.AddSingleton(massTransitSettings);

            services.AddSingleton<IEventBus, MassTransitEventBus>();

            return services;
        }
    }
}
