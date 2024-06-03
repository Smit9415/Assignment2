namespace assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product(1, "Product1", 10m, 10);
            product.StockCountIncrease(10);
            product.StockCountDecrease(10);
            Console.WriteLine("Stock : " + product.Stock);
        }
    }
}