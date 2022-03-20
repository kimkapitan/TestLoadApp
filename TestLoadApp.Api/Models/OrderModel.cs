#nullable disable
using Microsoft.AspNetCore.Identity;

namespace TestLoadApp.Api.Models
{ 
    public class OrderModelRequest
    {
        public IEnumerable<OrderItem> Items { get; set; }
    }

    public class OrderItem
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

    public class OrderModelResponse : OrderModelRequest
    {
        public string State { get; set; }
        public string UserId { get; set; }
        public int Id { get; set; }
        public DateTime Created { get; set; }
    }

    public class Order
    {
        public string State { get; set; }
        public string UserId { get; set; }
        public IdentityUser User { get; set; }
        public int Id { get; set; }
        public DateTime Created { get; set; }

        public IEnumerable<OrderItem> Items { get; set; }
    }
}
