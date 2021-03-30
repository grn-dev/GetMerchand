using System.ComponentModel;

namespace GetMerchant.Enums {

    public enum ShaparakRequestType {
        
        [Description("درخواست پایانه جدید از طرف شرکت ارائه دهنده خدمات پرداخت")]
        RequestNewTerminalFromPsp = 5,

        [Description("درخواست تغییر شباهای پایانه از طرف شرکت ارائه دهنده خدمات پرداخت")]
        RequestChangeTerminalIbanFromPsp = 6,

        [Description("درخواست غیرفعال سازی پایانه از طرف شرکت ارائه دهنده خدمات پرداخت")]
        RequestDisableTerminalFromPsp = 7,

        
        [Description("ثبت مشتری و فروشگاه")]
        RegisterCustomerOrShop = 13,

        [Description("اصلاح اطلاعات")]
        UpdateInfo = 14,

        [Description("تغییر آدرس فروشگاه پذیرندگی")]
        ChangeMerchantShopAddress = 17,
        
        [Description("فعال سازی مجدد ترمینال")]
        ReEnableTerminal = 18

    }
}
