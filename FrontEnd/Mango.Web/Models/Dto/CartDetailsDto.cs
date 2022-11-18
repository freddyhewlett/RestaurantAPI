namespace Mango.Web.Models.Dto
{
    public class CartDetailsDto
    {
        public Guid CartDetailsId { get; set; }
        public Guid CartHeaderId { get; set; }
        public Guid ProductId { get; set; }
        public int Count { get; set; }
        public virtual CartHeaderDto CartHeader { get; set; }
        public virtual ProductDto Product { get; set; }
    }
}
