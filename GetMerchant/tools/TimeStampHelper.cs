using System;
using System.Collections.Generic;
using System.Text;

namespace GetMerchant.tools
{
    public static class TimeStampHelper
    {

        private static readonly DateTime Epoch =
            new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
 
        public static long ToTimestamp(this DateTime value)
        {
            TimeSpan elapsedTime = value - Epoch;
            return (long)elapsedTime.TotalSeconds;
        }

          
        public static long ToTimestamp3(this DateTime value)
        {
            long epoch = (value.Ticks - 621355968000000000) / 10000;
            return epoch;
        }
    }
}
