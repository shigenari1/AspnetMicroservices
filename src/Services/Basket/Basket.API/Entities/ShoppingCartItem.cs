namespace Basket.API.Entities
{
    public class ShoppingCartItem
    {
        // 数量
        public int Quantity { get; set; }
        
        // 色
        public string Color { get; set; }
        
        // 値段
        public decimal Price { get; set; }
        
        // 商品ID
        public string ProductId { get; set; }
        
        // 商品名
        public string ProductName { get; set; }
    }
}