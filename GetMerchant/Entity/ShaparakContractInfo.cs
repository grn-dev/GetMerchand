using GetMerchant.tools;
using Newtonsoft.Json;
using System;
using System.Text.Json.Serialization;

namespace GetMerchant.Entity
{
    public class ShaparakContractInfo
    {
         
        [JsonProperty("contractDate")]
        public long ContractDate => ContractDateValue.ToTimestamp3();


        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime ContractDateValue { get; set; }

        
        [JsonProperty("expiryDate")]
        public long? ExpiryDate => ExpiryDateValue?.ToTimestamp3();


        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime? ExpiryDateValue { get; set; }

        
        [JsonProperty("serviceStartDate")]
        public long ServiceStartDate => ServiceStartDateValue.ToTimestamp3();

         
        [System.Text.Json.Serialization.JsonIgnore]
        public DateTime ServiceStartDateValue { get; set; }

         
        [JsonProperty("contractNumber")]
        public string ContractNumber { get; set; }

        
        public string Description { get; set; }

        public string ToJson() => this.SerializeToString();
    }
}