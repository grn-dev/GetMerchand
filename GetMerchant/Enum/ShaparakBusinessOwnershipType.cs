using System.ComponentModel;

namespace GetMerchant.Enums {

   
    public enum ShaparakBusinessOwnershipType {

        [Description("مالک")]
        Owner = 0,
        
        [Description("مستاجر")]
        Tenant = 1
    }
}
