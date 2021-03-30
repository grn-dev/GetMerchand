using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GetMerchant.Entity
{
    public class ShaparakMerchantIbanInfo
    {
         
        [JsonProperty("merchantIban")]
        public string Iban { get; set; }

        [Required, Description("عنوان شبا")]
        public string Description { get; set; }

        //public string ToJson() => this.SerializeToString();
    }
}