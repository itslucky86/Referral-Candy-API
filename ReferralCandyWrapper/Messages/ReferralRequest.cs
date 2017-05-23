using System;
using System.Collections.Specialized;

namespace ReferralCandyWrapper.Messages
{
    /// <summary>
    /// URL: https://www.referralcandy.com/api#referral
    /// </summary>
    public class ReferralRequest : BaseRequest
    {
        public string CustomerEmail { get; set; }
        public bool Notify { get; set; }
        public bool Returned { get; set; }

        public ReferralRequest() : base("referral", "POST")
        {
        }

        protected internal override NameValueCollection GetNameValueCollection(string accessID)
        {
            var collection = new NameValueCollection();
            collection.Add("accessID", accessID ?? string.Empty);
            collection.Add("timestamp", Convert.ToString(Common.GetUnixTimestamp()));
            collection.Add("customer_email", CustomerEmail ?? string.Empty);
            collection.Add("notify", Notify.ToString());
            collection.Add("returned", Returned.ToString());

            return collection;
        }
    }
}
