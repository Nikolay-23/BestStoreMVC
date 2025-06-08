﻿using Microsoft.EntityFrameworkCore;

namespace BestStoreMVC.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string ClientId { get; set; } = null!;
        public ApplicationUser Client { get; set; } = null!;

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        [Precision(16,2)] 
        public decimal ShippingFee { get; set; }

        public string DeliveryAddress { get; set; } = null!;
        public string PaymentMethod { get; set; } = null!;
        public string PaymentStatus { get; set; } = null!;
        public string PaymentDetails { get; set; } = null!; // to store PayPal details
        public string OrderStatus { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
    }
}
