# ReferralCandy C# API Client
Microsoft .NET Framework 4.0

## Usage
### Initialization
Initialize an object with your ReferralCandy credentials

	IReferralCandy referralCandy = new ReferralCandy("ACCESS_ID", "API_SECRET_KEY");

### Verification
Verify your credentials.

	var response = referralCandy.Verify(new VerifyRequest());
	Console.WriteLine("HTTP Code: {0}", response.HttpCode);
	Console.WriteLine("Message: {0}", response.Message);

### API Methods
The ReferralCandy API client will perform the authentication steps for you. This means that you would not be required to pass in the 'timestamp', 'accessID', 'apiSecretKey', and 'signature' parameters. But, you need to pass a request object as an argument.

[API endpoints](http://www.referralcandy.com/api) are available as methods in the ReferralCandy API client.

API responses are wrapped in a response object.

e.g.

	var purchaseRequest = new PurchaseRequest
	{
		FirstName = "Usman",
		LastName = "Chohan",
		Email = "info@usmanchohan.co.uk",
		CurrencyCode = "GBP",
		BrowserIP = "172.0.0.1", //optional
		UserAgent = "Chrome", //optional
		OrderDateTime = DateTime.Now,
		InvoiceAmount = 25.50M,
		ExternalReferenceID = "A123"
	};

	var response = referralCandy.Purchase(purchaseRequest);

	Console.WriteLine("HTTP Code: {0}", response.HttpCode);
	Console.WriteLine("Message: {0}", response.Message);
	Console.WriteLine("RAW Message: {0}", response.RawMessage);
	Console.WriteLine("Referral Corner URL: {0}", response.ReferralCornerUrl);
	
##Additional Functionalities

* UnixTimeStampToDateTime //So we can convert the Unix date returned in response to C# date
e.g.

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

### I have Added following API methods
- Referral Method	=> URL: https://www.referralcandy.com/api#referral
- Referrals Method	=> URL: https://www.referralcandy.com/api#referrals
- Referral Method	=> URL: https://www.referralcandy.com/api#referrer
- SignUp Method		=> URL: https://www.referralcandy.com/api#signup
- Contacts Method	=> URL: https://www.referralcandy.com/api#contacts

- Updated Response Class to handle different type of responses for different Requests

## Credits
* [Extended From] https://github.com/oshinyil/ReferralCandyWrapper
* [API documentation](http://www.referralcandy.com/api)
* [Python wrapper for ReferralCandy API](https://github.com/ReferralCandy/referral_candy_python)
* [Ruby wrapper for ReferralCandy API](https://github.com/ReferralCandy/referral_candy)
