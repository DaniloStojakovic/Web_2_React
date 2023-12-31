﻿namespace Server.Models
{
    public class Order
    {
        public long Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double FinalPrice { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
        public int CommentRated { get; set; }
        public User Customer { get; set; }
        public long UserId { get; set; }
        public Article Article { get; set; }
        public long ArticleId { get; set; }
        public DateTime OrderTime { get; set; }
        public DateTime DeliveryTime { get; set; }
        public bool IsDeliverd { get; set; }
    }
}
