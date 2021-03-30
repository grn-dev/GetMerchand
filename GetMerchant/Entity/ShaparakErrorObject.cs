using Newtonsoft.Json;

namespace GetMerchant.Entity
{
    public class ShaparakErrorObject
    { 
        [JsonProperty("codeExceptionValue")]
        public int CodeExceptionValue { get; set; }

        
 

     
        public string FieldName { get; set; }
    }
}