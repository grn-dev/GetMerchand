using GetMerchant.Enums;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GetMerchant.Entity
{
    public class ShaparakRelatedMerchant : ShaparakMerchant
    {
        [Required, Description("نوع رابطه مشتریان")]
        [JsonProperty("relationType")]
        public ShaparakBusinessRelationshipType RelationType { get; set; }
         
    }
}