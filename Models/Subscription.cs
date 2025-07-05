namespace ITI_Raqmiya_MVC.Models
{
    public class Subscription
    {
        public Guid Id { get; set; } // Primary Key
        public Guid BuyerId { get; set; } // Foreign Key to User
        public Guid ProductId { get; set; } // Foreign Key to Product (the subscription product)
        public DateTime StartDate { get; set; }
        public DateTime NextPaymentDate { get; set; }
        public string Status { get; set; } = "active"; // e.g., "active", "cancelled", "paused", "failed"
        public string PaymentGatewaySubscriptionId { get; set; } = string.Empty; // ID from Stripe/PayPal etc.

        // Navigation properties
        public User Buyer { get; set; } = null!; // Required navigation property
        public Product Product { get; set; } = null!; // Required navigation property

    }
}
