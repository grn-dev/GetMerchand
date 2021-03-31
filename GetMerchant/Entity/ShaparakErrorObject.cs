using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GetMerchant.Entity
{
    public class ShaparakErrorObject
    {
        [Required]
        [Description("کد خطا")]
        [JsonProperty("codeExceptionValue")]
        public int CodeExceptionValue { get; set; }

        public ShaparakCodeExceptions CodeException
            => (ShaparakCodeExceptions)CodeExceptionValue;


        [Description("فیلد دارای خطا"), MaxLength(50),MinLength(2)]
        public string FieldName { get; set; }
    }
}