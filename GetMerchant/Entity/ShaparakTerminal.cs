using GetMerchant.tools;
using Newtonsoft.Json;
using GetMerchant.Enums;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GetMerchant.Entity
{
    public class ShaparakTerminal
    {
         
        [JsonProperty("sequence")]
        public int? Sequence { get; set; }

        [Required,   MinLength(8), MaxLength(8)]
        [JsonProperty("terminalNumber")]
        public string TerminalNumber { get; set; }

        
        [Required, Description("نوع پایانه")]
        [JsonProperty("terminalType")]
        public ShaparakTerminalType TerminalType { get; set; }

        [Description("سریال سخت افزار پایانه")]
        [JsonProperty("serialNumber")]
        public string SerialNumber { get; set; }

        [Required, Description("تاریخ فعال سازی")]
        [JsonProperty("setupDate")]
        public long SetupDate => SetupDateValue.ToTimestamp3();

         
        [JsonIgnore]
        public DateTime SetupDateValue { get; set; }

        [  MaxLength(50)]
        [JsonProperty("hardwareBrand")]
        public string HardwareBrand { get; set; }

        [  MaxLength(50)]
        [JsonProperty("hardwareModel")]
        public string HardwareModel { get; set; }

        
        [   MaxLength(100)]
        [JsonProperty("accessAddress")]
        public string AccessAddress { get; set; }

         
        [JsonProperty("accessPort")]
        public int AccessPort { get; set; }

         
        [  MinLength(7), MaxLength(100)]
        [JsonProperty("callbackAddress")]
        public string CallbackAddress { get; set; }
         
        [JsonProperty("callbackPort")]
        public int CallbackPort { get; set; }

         
        [  MaxLength(255)]
        [JsonProperty("Description")]
        public string Description { get; set; }

         
        [JsonProperty("updateAction")]
        public ShaparakUpdateAction? UpdateAction { get; set; }

    }
}