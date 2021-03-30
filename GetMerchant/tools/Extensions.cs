using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace GetMerchant.tools
{
    public static class Extensions
    {

        public static string SerializeToString(this object model)
            => JsonConvert.SerializeObject(model, Formatting.Indented);

    }
}
