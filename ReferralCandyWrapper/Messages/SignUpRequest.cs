using System;
using System.Collections.Specialized;

namespace ReferralCandyWrapper.Messages
{
    /// <summary>
    ///  //URL: https://www.referralcandy.com/api#signup
    /// </summary>
    public class SignUpRequest : BaseRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public SignUpRequest() : base("signup", "GET")
        {
        }

        protected internal override NameValueCollection GetNameValueCollection(string accessID)
        {
            var collection = new NameValueCollection();
            collection.Add("accessID", accessID ?? string.Empty);
            collection.Add("timestamp", Convert.ToString(Common.GetUnixTimestamp()));
            collection.Add("first_name", FirstName ?? string.Empty);
            collection.Add("last_name", LastName ?? string.Empty);
            collection.Add("email", Email ?? string.Empty);
            return collection;
        }
    }
}
