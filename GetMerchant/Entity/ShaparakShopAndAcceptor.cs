using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GetMerchant.Entity
{
    public class ShaparakShopAndAcceptor
    {
        [Required, Description("اطلاعات فروشگاه")]
        [JsonProperty("shop")]
        public ShaparakShop Shop { get; set; }
         


        [JsonProperty("acceptors")]
        [Description("اطلاعات پذیرندگی و پایانه های فروشگاه")]
        public List<ShaparakAcceptor> Acceptors { get; set; }

         

    }
}