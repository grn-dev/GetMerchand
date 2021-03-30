using System.ComponentModel;

namespace GetMerchant.Enums
{


    public enum ShaparakRequestStatus
    {

        [Description("رد نهایی")]
        FinalRejection = 5,

        [Description("در انتظار ارائه سرویس درخواستی")]
        WaitingForService = 8,

        [Description("تاخیر در پردازش")]
        DelayInProcessing = 12,

        [Description("تایید نهایی")]
        FinalAcceptance = 14,


        [Description("در پروسه بررسي و تاييد داخلي شاپرك")]
        inProcessShaparak = 20
    }
}
