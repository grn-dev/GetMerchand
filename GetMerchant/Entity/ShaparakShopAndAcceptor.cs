using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GetMerchant.Entity
{
    public class ShaparakShopAndAcceptor
    {
        [Required]
        [JsonProperty("shop")]
        public ShaparakShop Shop { get; set; }
         
        [JsonProperty("acceptors")]
        
        public List<ShaparakAcceptor> Acceptors { get; set; }

        //public string ToJson() => this.SerializeToString();

    }
}