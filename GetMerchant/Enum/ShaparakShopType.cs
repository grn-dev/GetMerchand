using System.ComponentModel;

namespace GetMerchant.Enums
{


    public enum ShaparakShopType
    {

        [Description("فروشگاه صرفا فیزیکی")]
        Physical = 0,

        [Description("فروشگاه فیزیکی و مجازی")]
        PhysicalAndVirtual = 1,

        [Description("فروشگاه صرفا مجازی")]
        Virtual = 2

    }
}
