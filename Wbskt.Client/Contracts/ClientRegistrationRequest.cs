using System.ComponentModel.DataAnnotations;

namespace Wbskt.Client.Contracts
{
    internal class ClientRegistrationRequest
    {
        [Required]
        public string Pin { get; set; }

        public string ClientName { get; set; }
    }
}
