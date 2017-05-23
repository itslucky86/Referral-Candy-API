using Newtonsoft.Json;
using System;

namespace ReferralCandyWrapper.Messages
{
    public class Response
    {
        #region Common Response 
        [JsonIgnore]
        public int HttpCode { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        public string RawMessage { get; set; }
        #endregion

        #region Purchase Response & SignUp Response

        [JsonProperty("referralcorner_url")]
        public string ReferralCornerUrl { get; set; }

        //SignUp Response
        [JsonProperty("referral_link")]
        public string ReferralUrl { get; set; }
        #endregion

        #region Referrals Response
        public Referrals[] Referrals { get; set; }

        private string _period_from;

        public string period_from
        {
            get { return _period_from; }

            set
            {
                _period_from = value;
                PeriodFrom = Common.UnixTimeStampToDateTime(Convert.ToDouble(value));
            }
        }

        private string _period_to;

        public string period_to
        {
            get { return _period_to; }

            set
            {
                _period_to = value;
                PeriodTo = Common.UnixTimeStampToDateTime(Convert.ToDouble(value));
            }
        }

        public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }

        #endregion

        #region ReferralMethod Response
        public string customer_email { get; set; }
        #endregion

        #region ReferrerMethod Response
        [JsonProperty("referrer")]
        public string Referrer_Email { get; set; }
        #endregion

        #region  Contacts Method Response
        [JsonProperty("contacts")]
        public Contacts[] Contacts { get; set; }

        [JsonProperty("total_count")]
        public string TotalCount { get; set; }
        #endregion
    }
}