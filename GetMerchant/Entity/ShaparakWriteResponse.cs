using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetMerchant.Entity
{

    public class ShaparakWriteResponse
    {
         
        [JsonProperty("trackingNumber")]
        public string TrackingNumber { get; set; }
         
        [JsonProperty("success")]
        public bool Success { get; set; }

         
        [JsonProperty("requestRejectionReason")]
        public List<ShaparakErrorObject> RejectionReason { get; set; }

        //public string ToJson() => this.SerializeToString();

    }
}
