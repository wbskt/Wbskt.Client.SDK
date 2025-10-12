namespace Wbskt.Client.Configurations
{
    /// <summary>
    /// We recommend using appsettings.json or IConfiguration to configure  <see cref="WbsktListener"/> thourgh the <see cref="WbsktConfiguration"/>.
    /// You can also use custom configuration with this class. See documentation for detailed explanation.
    /// </summary>
    public class WbsktConfigurationCustom : IWbsktConfiguration
    {
        /// <summary>
        /// Gets the Wbskt server address for the WebSocket client.
        /// </summary>
        public string WbsktServerAddress { get; set; } = "wbskt.com";

        /// <summary>
        /// Gets the client-specific details such as name, unique ID, and retry interval.
        /// </summary>
        public ClientDetails ClientDetails { get; set; }

        /// <summary>
        /// Gets the policy-specific details such as policy ref ID and pin.
        /// </summary>
        public PolicyDetails PolicyDetails { get; set; }
    }
}
