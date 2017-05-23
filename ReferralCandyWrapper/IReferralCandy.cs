using ReferralCandyWrapper.Messages;

namespace ReferralCandyWrapper
{
    public interface IReferralCandy
    {
        Response Verify(VerifyRequest request);

        Response Purchase(PurchaseRequest request);

        Response Referalls(ReferralsRequest request);

        Response ReferralMethod(ReferralRequest request);

        Response ReferrerMethod(ReferrerRequest request);

        Response Contacts(ContactsRequest request);
        Response SignUp(SignUpRequest request);
    }
}