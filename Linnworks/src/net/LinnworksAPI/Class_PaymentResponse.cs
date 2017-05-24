namespace LinnworksAPI
{
    public class PaymentResponse
    {
        public PaymentStatus CurrentStatus;
        public string Message;
        public string TransactionId;
        public string ProfileId;
        public CheckoutRequest CheckoutRequest;
        public CheckoutData CheckoutData;
    }
}