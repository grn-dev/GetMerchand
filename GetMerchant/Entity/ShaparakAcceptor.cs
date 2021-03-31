using Newtonsoft.Json;
using GetMerchant.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GetMerchant.Entity
{
    public class ShaparakAcceptor
    {

        [Required , MinLength(6), MaxLength(9)]
        [JsonProperty("iin")]
        public string Iin { get; set; }

        [Required , MinLength(15), MaxLength(15)]
        [JsonProperty("acceptorCode")]
        public string AcceptorCode { get; set; }

        [Required  ]
        public ShaparakAcceptorType AcceptorType { get; set; }

      
        [  MinLength(15), MaxLength(15)]
        [JsonProperty("facilitatorAcceptorCode")]
        public string FacilitatorAcceptorCode { get; set; }

        [Required ]
        [JsonProperty("cancelable")]
        public bool Cancelable { get; set; }

        [Required ]
        [JsonProperty("refundable")]
        public bool Refundable { get; set; }

      
        [Required  ]
        [JsonProperty("blockable")]
        public bool Blockable { get; set; }

        [Required ]
        [JsonProperty("chargeBackable")]
        public bool ChargeBackable { get; set; }

     
        [Required ]
        [JsonProperty("settledSeparately")] 
        public bool SettledSeparately { get; set; }

        
        [Required ]
        [JsonProperty("allowScatteredSettlement")]
        public ShaparakScatteredSettlementType AllowScatteredSettlement { get; set; }

         
        [Required ]
        [JsonProperty("acceptCreditCardTransaction")]
        public bool AcceptCreditCardTransaction { get; set; }

        [Required ]
        [JsonProperty("allowIranianProductsTrx")]
        public bool AllowIranianProductsTrx { get; set; }

        [Required ]
        [JsonProperty("allowKaraCardTrx")]
        public bool AllowKaraCardTrx { get; set; }

        [Required  ]
        [JsonProperty("allowGoodsBasketTrx")]
        public bool AllowGoodsBasketTrx { get; set; }

        [Required ]
        [JsonProperty("AllowFoodSecurityTrx")]
        public bool AllowFoodSecurityTrx { get; set; }

        [Required ]
        [JsonProperty("AllowUpiCardTrx")]
        public bool AllowUpiCardTrx { get; set; }

        [Required ]
        [JsonProperty("AllowVisaCardTrx")]
        public bool AllowVisaCardTrx { get; set; }

        [Required  ]
        [JsonProperty("AllowMasterCardTrx")]
        public bool AllowMasterCardTrx { get; set; }

        [Required ]
        [JsonProperty("AllowAmericanExpressTrx")]
        public bool AllowAmericanExpressTrx { get; set; }
 
        [Required ]
        [JsonProperty("AllowOtherInternationaCardsTrx")]
        public bool AllowOtherInternationalCardsTrx { get; set; }
         
        [Required ]
        public bool AllowJcbCardTrx { get; set; }

        
        [Required ]
        [JsonProperty("terminals")]
        public List<ShaparakTerminal> Terminals { get; set; }

          
        [JsonProperty("shaparakSettlementIbans")]
        public List<string> ShaparakSettlementIbans { get; set; }

         
        [JsonProperty("Description")]
        public string Description { get; set; }

      
        [JsonProperty("updateAction")]
        public ShaparakUpdateAction? UpdateAction { get; set; }

        //public string ToJson() => this.SerializeToString();
    }
}