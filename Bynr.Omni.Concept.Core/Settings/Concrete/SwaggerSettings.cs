using Microsoft.OpenApi.Models;
using Bynr.Omni.Concept.Core.Settings.Abstract;

namespace Bynr.Omni.Concept.Core.Settings.Concrete
{
    /// <summary>
    /// 
    /// </summary>
    public class SwaggerSettings : OpenApiInfo, ISettings
    {
        /// <summary>
        /// 
        /// </summary>
        public string VersionName { get; set; } = "v1";

        /// <summary>
        /// 
        /// </summary>
        public string RoutePrefix { get; set; } = "";
    }
}
