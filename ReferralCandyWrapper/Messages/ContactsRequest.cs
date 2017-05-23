using System;
using System.Collections.Specialized;

namespace ReferralCandyWrapper.Messages
{
    /// <summary>
    /// URL: https://www.referralcandy.com/api#contacts
    /// </summary>
    public class ContactsRequest : BaseRequest
    {
        public string ID { get; set; }
        public string Limit { get; set; }
        public string Email { get; set; }


        public ContactsRequest() : base("contacts", "GET")
        {
        }

        protected internal override NameValueCollection GetNameValueCollection(string accessID)
        {
            var collection = new NameValueCollection();
            collection.Add("accessID", accessID ?? string.Empty);
            collection.Add("timestamp", Convert.ToString(Common.GetUnixTimestamp()));
            collection.Add("id", ID ?? string.Empty);
            collection.Add("limit", Limit ?? string.Empty);
        

            return collection;
        }

    }

    public class Contacts
    {
        public string id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string purchase_made { get; set; }
        public Purchases[] purchases { get; set; }
        public string unsubscribed { get; set; }
    }

    public class Purchases
    {
        private string _purchased_at;

        public string purchased_at {
            get { return _purchased_at; }

            set
            {
                _purchased_at = value;
                PurchasedDate = Common.UnixTimeStampToDateTime(Convert.ToDouble(value));

            }

        }
        public string amount { get; set; }

        public DateTime PurchasedDate { get; set; }

    }
}
