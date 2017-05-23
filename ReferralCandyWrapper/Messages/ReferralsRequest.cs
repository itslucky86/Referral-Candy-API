using System;
using System.Collections.Specialized;

namespace ReferralCandyWrapper.Messages
{
    /// <summary>
    /// URL: https://www.referralcandy.com/api#referrals
    /// </summary>
    public class ReferralsRequest : BaseRequest
    {
        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        public string Email { get; set; }
        public bool Pending_Review_Only { get; set; }

        public ReferralsRequest() : base("referrals", "POST")
        {
        }

        protected internal override NameValueCollection GetNameValueCollection(string accessID)
        {
            var collection = new NameValueCollection();
            collection.Add("accessID", accessID ?? string.Empty);
            collection.Add("timestamp", Convert.ToString(Common.GetUnixTimestamp()));
            collection.Add("period_from", Convert.ToString(Common.GetUnixTimestamp(PeriodFrom)));
            collection.Add("period_to", Convert.ToString(Common.GetUnixTimestamp(PeriodTo)));
            collection.Add("customer_email", Email ?? string.Empty);
            collection.Add("pending_review_only", Pending_Review_Only.ToString());

            return collection;
        }
    }

    public class Referrals
    {
        public string referral_email { get; set; }

        private string _referral_timestamp;

        public string referral_timestamp
        {
            get { return _referral_timestamp; }

            set
            {
                _referral_timestamp = value;
                ReferralDateTime = Common.UnixTimeStampToDateTime(Convert.ToDouble(value));
            }
        }

        public DateTime ReferralDateTime { get; set; }

        public string referring_email { get; set; }
        public string review_period_over { get; set; }
        public string external_reference_id { get; set; }
    }
}