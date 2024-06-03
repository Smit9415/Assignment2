namespace assignment
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(int productId, string productName, decimal price, int stock)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Stock = stock;
        }

        public void StockCountIncrease(int pStock)
        {
            if (pStock > 0)
            {
                Stock = Stock + pStock;
            }
        }

        public void StockCountDecrease(int pStock)
        {
            if (pStock > 0)
            {
                Stock = Stock - pStock;
            }
        }
    }
}
