using Newtonsoft.Json;
using GetMerchant.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GetMerchant.Entity
{
    public class ShaparakWriteRequest
    {
         
        [JsonProperty("trackingNumberPsp")]
        public string PspTrackingNumber { get; set; }
        
        [JsonProperty("requestType")]
        public ShaparakRequestType RequestType { get; set; }

         
        [JsonProperty("merchant")]
        public ShaparakMerchant Merchant { get; set; }

         
        [JsonProperty("relatedMerchants")]
        public List<ShaparakRelatedMerchant> RelatedMerchants { get; set; }

         
        [JsonProperty("Contract")]
        public ShaparakContractInfo Contract { get; set; }

         
        [JsonProperty("pspRequestShopAcceptors")]
        public List<ShaparakShopAndAcceptor> ShopAcceptors { get; set; }

          
        [JsonProperty("Description")]
        public string Description { get; set; }

        //public string ToJson() => this.SerializeToString();
    }
}
