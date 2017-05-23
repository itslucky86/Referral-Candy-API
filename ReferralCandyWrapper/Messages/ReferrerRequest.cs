using System;
using System.Collections.Specialized;

namespace ReferralCandyWrapper.Messages
{
    /// <summary>
    ///  //URL: https://www.referralcandy.com/api#referrer
    /// </summary>
    public class ReferrerRequest : BaseRequest
    {
        public string CustomerEmail { get; set; }

        public ReferrerRequest() : base("referrer", "GET")
        {
        }

        protected internal override NameValueCollection GetNameValueCollection(string accessID)
        {
            var collection = new NameValueCollection();
            collection.Add("accessID", accessID ?? string.Empty);
            collection.Add("timestamp", Convert.ToString(Common.GetUnixTimestamp()));
            collection.Add("customer_email", CustomerEmail ?? string.Empty);

            return collection;
        }
    }
}
