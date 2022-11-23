using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mango.Services.OrderAPI.Models
{
    public class OrderDetails
    {
        [Key]
        public Guid OrderDetailsId { get; set; }
        [ForeignKey("OrderHeaderId")]
        public Guid OrderHeaderId { get; set; }
        public Guid ProductId { get; set; }
        public int Count { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public virtual OrderHeader OrderHeader { get; set; }
    }
}
