using System.ComponentModel;

namespace GetMerchant.Enums {
    
    
    public enum ShaparakTerminalRemovedReason {

        [Description("اتمام فعالیت")]
        BusinessOut = 0,

        [Description("ضعف خدمات ارائه دهنده سرویس")]
        ServiceProviderWeakness = 1,

        [Description("عدم نیاز")]
        NoNeed = 2,

        [Description("سایر دلایل")]
        OtherReasons = 3
    }
}
