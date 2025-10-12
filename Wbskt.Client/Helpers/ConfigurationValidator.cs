using Microsoft.Extensions.Logging;
using Wbskt.Client.Configurations;

namespace Wbskt.Client.Helpers
{
    /// <summary>
    /// Validates the WebSocket configuration.
    /// </summary>
    internal static class ConfigurationValidator
    {
        public static bool IsValid(IWbsktConfiguration configuration, ILogger logger)
        {
            if (configuration == null)
            {
                logger?.LogError("Configuration is not set.");
                return false;
            }

            if (configuration.PolicyDetails.Pin == default)
            {
                logger?.LogError("Pin is not set.");
                return false;
            }

            if (configuration.ClientDetails.UniqueId == default)
            {
                logger?.LogError("UniqueId is not set.");
                return false;
            }

            return true;
        }
    }
}
