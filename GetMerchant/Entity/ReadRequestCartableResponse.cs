using Newtonsoft.Json;
using GetMerchant.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetMerchant.Entity
{

    public class ReadRequestCartableResponse
    {
 
        [JsonProperty("trackingNumber")]
        public string TrackingNumber { get; set; }

         
        [JsonProperty("trackingNumberPsp")]
        public string PspTrackingNumber { get; set; }

        
        [JsonProperty("Status")]
        public ShaparakRequestStatus Status { get; set; }

         
        [JsonProperty("description")]
        public string Description { get; set; }

         
        [JsonProperty("requestType")]
        public ShaparakRequestType RequestType { get; set; }

         
        [JsonProperty("merchant")]
        public ShaparakMerchant Merchant { get; set; }

         
        [JsonProperty("relatedMerchants")]
        public List<ShaparakRelatedMerchant> RelatedMerchants { get; set; }

         
        [JsonProperty("requestRejectionReasons")]
        public List<ShaparakErrorObject> RejectionReasons { get; set; }

          
        [JsonProperty("requestDetails")]
        public object Details { get; set; }

        //public string ToJson() => this.SerializeToString();

    }
}
