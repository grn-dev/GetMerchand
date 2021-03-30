using GetMerchant.tools;
using Newtonsoft.Json;
using GetMerchant.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetMerchant.Entity
{
    public class ShaparakReadRequest
    {
        [JsonIgnore]
        public DateTime RequestStartDateValue { get; set; }

        [JsonIgnore]
        public DateTime RequestFinishDateValue { get; set; }

        [JsonProperty("requestDate")]
        public List<long> RequestDate =>
            new List<long>
            {
                RequestStartDateValue.ToTimestamp3(),
                RequestFinishDateValue.ToTimestamp3()
            };

        
        [JsonProperty("requestTypes")]
        public List<ShaparakRequestType> RequestTypes { get; set; }

         
        [JsonProperty("statuses")]
        public List<ShaparakRequestStatus> Statuses { get; set; }

         
        [JsonProperty("trackingNumbers")]
        public List<string> TrackingNumbers { get; set; }
 
        [JsonProperty("trackingNumbersPsps")]
        public List<string> PspTrackingNumbers { get; set; }



    }
}
