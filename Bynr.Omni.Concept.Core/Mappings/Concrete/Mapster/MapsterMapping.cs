using Mapster;
using Bynr.Omni.Concept.Core.Mappings.Abstract;

namespace Bynr.Omni.Concept.Core.Mappings.Concrete.Mapster
{
    /// <summary>
    /// 
    /// </summary>
    public class MapsterMapping : IMapping
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TDestination"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return source.Adapt<TDestination>();
        }
    }
}
