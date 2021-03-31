using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GetMerchant.Entity
{
    public class ShaparakMerchantIbanInfo
    {
        
       [JsonProperty("merchantIban")]
        [Required, Description("شماره شبا"),MaxLength(34),MinLength(26)]
        public string Iban { get; set; }


        [JsonProperty("description")]
        [Required, Description("عنوان شبا"), MaxLength(255), MinLength(1)]
        public string Description { get; set; } 

    }
}