using System.ComponentModel;

namespace GetMerchant.Enums {
    
     
    public enum ShaparakScatteredSettlementType {

        [Description("عدم امکان تقسیم وجوه")]
        NotAllowed = 0,

        [Description("امکان تقسیم وجوه در یک بانک")]
        AllowedInOneBankOnly = 1,
        
        [Description("امکان تقسیم وجوه در بانک های مختلف")]
        AllowedInDifferentBanks = 2
    }
}
