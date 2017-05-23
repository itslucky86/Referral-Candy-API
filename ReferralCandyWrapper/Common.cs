using System;

namespace ReferralCandyWrapper
{
    internal static class Common
    {
        public static int GetUnixTimestamp()
        {
            return ToUnixTimestamp(DateTime.UtcNow);
        }

        public static int GetUnixTimestamp(DateTime dateTime)
        {
            return ToUnixTimestamp(dateTime.ToUniversalTime());
        }

        private static int ToUnixTimestamp(DateTime dateTime)
        {
            return (int)(dateTime.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix time-stamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }
    }
}
