using System.ComponentModel;

namespace GetMerchant.Enums {

    
    public enum ShaparakTerminalType {

        [Description("پایانه فروش رومیزی")]
        DesktopPOS = 0,
        
        [Description("درگاه پرداخت اینترنتی")]
        Ipg = 1,
        
        [Description("درگاه پرداخت موبایلی")]
        Mpg = 2,
        
        [Description("پایانه فروش بی سیم")]
        WirelessPOS = 3
        
    }
}
