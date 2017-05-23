using ReferralCandyWrapper.Messages;

namespace ReferralCandyWrapper
{
    public class ReferralCandy : IReferralCandy
    {
        private readonly HttpClient httpClient;

        public ReferralCandy(string accessID, string secretKey)
        {
            httpClient = new HttpClient(accessID, secretKey);
        }

        public Response Verify(VerifyRequest request)
        {
            return httpClient.ProcessRequest(request);
        }

        public Response Purchase(PurchaseRequest request)
        {
            return httpClient.ProcessRequest(request);
        }

        public Response Referalls(ReferralsRequest request)
        {
            return httpClient.ProcessRequest(request);
        }

        public Response ReferralMethod(ReferralRequest request)
        {
            return httpClient.ProcessRequest(request);
        }

        public Response ReferrerMethod(ReferrerRequest request)
        {
            return httpClient.ProcessRequest(request);
        }

        public Response Contacts(ContactsRequest request)
        {
            return httpClient.ProcessRequest(request);
        }

        public Response SignUp(SignUpRequest request)
        {
            return httpClient.ProcessRequest(request);
        }
    }
}