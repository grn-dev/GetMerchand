using Newtonsoft.Json;
using GetMerchant.Enums;

namespace GetMerchant.Entity
{
    public class ShaparakRelatedMerchant
    {
        [JsonProperty("relationType")]
        public ShaparakBusinessRelationshipType RelationType { get; set; }
    }
}