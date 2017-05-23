using ReferralCandyWrapper;
using ReferralCandyWrapper.Messages;
using System;

namespace ReferralCandyConsoleClient
{
    internal class Program
    {
        private const string AccessID = "YOUR-ACCESS-ID";
        private const string SecreteKey = "YOUR-SECRETE-KEY";
        private static void Main(string[] args)
        {
            #region Purchase Method

            //URL: https://www.referralcandy.com/api#purchase
            //DoPurchase();

            #endregion Purchase Method

            #region Referral Method

            //URL: https://www.referralcandy.com/api#referral
            //DoReferralMethod();

            #endregion Referral Method

            #region Referrals Method

            //URL: https://www.referralcandy.com/api#referrals
            // DoReferrals();

            #endregion Referrals Method

            #region Referrer Method

            //URL: https://www.referralcandy.com/api#referrer

            //DoReferrer();

            #endregion Referrer Method

            #region Contacts Method

            //URL: https://www.referralcandy.com/api#contacts
            //DoContacts();

            #endregion Contacts Method

            #region SignUp Method

            //URL: https://www.referralcandy.com/api#signup

            //DoSignUp();

            #endregion SignUp Method
        }

        public static void DoPurchase()
        {
            IReferralCandy referralCandy = new ReferralCandy(AccessID, SecreteKey);

            Console.WriteLine("Verify...");

            var response = referralCandy.Verify(new VerifyRequest());

            Console.WriteLine("HTTP Code: {0}", response.HttpCode);
            Console.WriteLine("Message: {0}", response.Message);

            Console.WriteLine("Purchase...");

            var purchaseRequest = new PurchaseRequest
            {
                FirstName = "usman",
                LastName = "chohan",
                Email = "info@usmanchohan.co.uk",
                CurrencyCode = "GBP",
                // BrowserIP = "172.0.0.1",
                // UserAgent = "Chrome",
                OrderDateTime = DateTime.Now,
                InvoiceAmount = 14.99M,
                ExternalReferenceID = "DWBSFKN"
            };

            response = referralCandy.Purchase(purchaseRequest);

            Console.WriteLine("HTTP Code: {0}", response.HttpCode);
            Console.WriteLine("Message: {0}", response.Message);
            Console.WriteLine("RAW Message: {0}", response.RawMessage);
            Console.WriteLine("Referral Corner URL: {0}", response.ReferralCornerUrl);

            Console.ReadLine();
        }

        public static void DoReferralMethod()
        {
            IReferralCandy referralCandy = new ReferralCandy(AccessID, SecreteKey);

            Console.WriteLine("Verify...");

            var response = referralCandy.Verify(new VerifyRequest());

            Console.WriteLine("HTTP Code: {0}", response.HttpCode);
            Console.WriteLine("Message: {0}", response.Message);

            Console.WriteLine("ReferralMethod...");

            var ReferralMethod = new ReferralRequest
            {
                CustomerEmail = "info@usmanchohan.co.uk",
                Notify = false,
                Returned = false
            };

            response = referralCandy.ReferralMethod(ReferralMethod);

            Console.WriteLine("HTTP Code: {0}", response.HttpCode);
            Console.WriteLine("Message: {0}", response.Message);
            Console.WriteLine("RAW Message: {0}", response.RawMessage);
            Console.WriteLine("Referral Corner URL: {0}", response.ReferralCornerUrl);

            Console.ReadLine();
        }

        public static void DoReferrals()
        {
            IReferralCandy referralCandy = new ReferralCandy(AccessID, SecreteKey);

            Console.WriteLine("Verify...");

            var response = referralCandy.Verify(new VerifyRequest());

            Console.WriteLine("HTTP Code: {0}", response.HttpCode);
            Console.WriteLine("Message: {0}", response.Message);

            Console.WriteLine("Referrals...");

            var refferalsRequest = new ReferralsRequest
            {
                PeriodFrom = DateTime.Now.AddDays(-2),
                PeriodTo = DateTime.Now
            };

            response = referralCandy.Referalls(refferalsRequest);

            Console.WriteLine("HTTP Code: {0}", response.HttpCode);
            Console.WriteLine("Message: {0}", response.Message);
            Console.WriteLine("RAW Message: {0}", response.RawMessage);
            Console.WriteLine("Referral Corner URL: {0}", response.ReferralCornerUrl);

            Console.ReadLine();
        }

        public static void DoReferrer()
        {
            IReferralCandy referralCandy = new ReferralCandy(AccessID, SecreteKey);

            Console.WriteLine("Verify...");

            var response = referralCandy.Verify(new VerifyRequest());

            Console.WriteLine("HTTP Code: {0}", response.HttpCode);
            Console.WriteLine("Message: {0}", response.Message);

            Console.WriteLine("Referrals...");

            var request = new ReferrerRequest
            {
                CustomerEmail = "info@usmanchohan.co.uk"
            };

            response = referralCandy.ReferrerMethod(request);

            Console.WriteLine("HTTP Code: {0}", response.HttpCode);
            Console.WriteLine("Message: {0}", response.Message);
            Console.WriteLine("RAW Message: {0}", response.RawMessage);
            Console.WriteLine("Referral Corner URL: {0}", response.ReferralCornerUrl);

            Console.ReadLine();
        }

        public static void DoContacts()
        {
            IReferralCandy referralCandy = new ReferralCandy(AccessID, SecreteKey);

            Console.WriteLine("Verify...");

            var response = referralCandy.Verify(new VerifyRequest());

            Console.WriteLine("HTTP Code: {0}", response.HttpCode);
            Console.WriteLine("Message: {0}", response.Message);

            Console.WriteLine("Referrals...");

            var request = new ContactsRequest
            {
                Limit = "100"
            };

            response = referralCandy.Contacts(request);

            Console.WriteLine("HTTP Code: {0}", response.HttpCode);
            Console.WriteLine("Message: {0}", response.Message);
            Console.WriteLine("RAW Message: {0}", response.RawMessage);
            Console.WriteLine("Referral Corner URL: {0}", response.ReferralCornerUrl);

            Console.ReadLine();
        }

        public static void DoSignUp()
        {
            IReferralCandy referralCandy = new ReferralCandy(AccessID, SecreteKey);

            Console.WriteLine("Verify...");

            var response = referralCandy.Verify(new VerifyRequest());

            Console.WriteLine("HTTP Code: {0}", response.HttpCode);
            Console.WriteLine("Message: {0}", response.Message);

            Console.WriteLine("Referrals...");

            var request = new SignUpRequest
            {
                FirstName = "Usman",
                LastName = "Akram",
                Email = "info@usmanchohan.co.uk"
            };

            response = referralCandy.SignUp(request);

            Console.WriteLine("HTTP Code: {0}", response.HttpCode);
            Console.WriteLine("Message: {0}", response.Message);
            Console.WriteLine("RAW Message: {0}", response.RawMessage);
            Console.WriteLine("Referral Corner URL: {0}", response.ReferralCornerUrl);

            Console.ReadLine();
        }
    }
}