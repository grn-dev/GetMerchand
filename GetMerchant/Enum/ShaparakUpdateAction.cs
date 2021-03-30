using System.ComponentModel;

namespace GetMerchant.Enums {
    
    
    public enum ShaparakUpdateAction {
        
        [Description("اصلاح")]
        Update = 0,
        
      
        [Description("حذف یا غیرفعال سازی")]
        Remove = 1,
        
        [Description("بدون تغییر")]
        NoChange = 2
        
    }
}
