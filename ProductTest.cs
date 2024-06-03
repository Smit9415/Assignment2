using NUnit.Framework;

namespace assignment.Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void CheckId_ProductId_WithinRange()
        {
            var product = new Product(43, "Product1", 540.0m, 54);
            var productId = product.ProductID;
            Assert.That(productId, Is.InRange(4, 40000));
        }

        [Test]
        public void CheckId_ProductId_NotNullOrEmpty()
        {
            var product = new Product(10, "Product1", 310.0m, 56);
            var productId = product.ProductID;
            Assert.That(productId, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void CheckId_ProductId25_True()
        {
            var product = new Product(25, "Product1", 130.0m, 34);
            var productId = product.ProductID;
            Assert.That(productId, Is.EqualTo(25));
        }

        [Test]
        public void CheckName_ProductNameTest_True()
        {
            var product = new Product(23, "Test", 10.0m, 10);
            var productName = product.ProductName;
            Assert.That(productName, Is.EqualTo("Test"));
        }

        [Test]
        public void CheckName_ProductNameTest_NotNull()
        {
            var product = new Product(54, "Test", 10.0m, 23);
            var productName = product.ProductName;
            Assert.That(productName, Is.Not.Null);
        }

        [Test]
        public void CheckName_ProductNameSpace_True()
        {
            var product = new Product(34, "  ", 10.0m, 43);
            var productName = product.ProductName;
            Assert.That(productName, Is.EqualTo("  "));
        }

        [Test]
        public void CheckPrice_Price_WithinRange()
        {
            var product = new Product(64, "Product1", 345.0m, 43);
            var price = product.Price;
            Assert.That(price, Is.InRange(4, 40000));
        }

        [Test]
        public void CheckPrice_Price_True()
        {
            var product = new Product(10, "Product1", 40.0m, 10);
            var price = product.Price;
            Assert.That(price, Is.EqualTo(40.0m));
        }

        [Test]
        public void CheckPrice_Price_NotNullOrEmpty()
        {
            var product = new Product(10, "Product1", 230.0m, 10);
            var price = product.Price;
            Assert.That(price, Is.Not.Null.Or.Empty);
        }

        
        [Test]
        public void Stock_Input22_True()
        {
            var product = new Product(43, "Milk", 540.0m, 22);
            var stock = product.Stock;
            Assert.That(stock, Is.InRange(4, 400000));
        }

        [Test]
        public void Stock_Input45_False()
        {
            var product = new Product(10, "Milk", 310.0m, 45);
            var stock = product.Stock;
            Assert.That(stock, Is.Not.Null.Or.Empty);
        }

        [Test]
        public void Stock_Input34_True()
        {
            var product = new Product(25, "Milk", 130.0m, 34);
            var stock = product.Stock;
            Assert.That(stock, Is.EqualTo(34));
        }

        [Test]
        public void IncreseStock_Input22_True()
        {
            var product = new Product(43, "Milk", 540.0m, 22);
            product.StockCountIncrease(10);
            var stock = product.Stock;
            Assert.That(stock, Is.EqualTo(32));
        }

        [Test]
        public void IncreseStock_Input45_True()
        {
            var product = new Product(10, "Milk", 310.0m, 45);
            product.StockCountIncrease(5000);
            var stock = product.Stock;
            Assert.That(stock, Is.EqualTo(5045));
        }

        [Test]
        public void IncreseStock_Input34_True()
        {
            var product = new Product(25, "Milk", 130.0m, 399900);
            product.StockCountIncrease(300);
            var stock = product.Stock;
            Assert.That(stock, Is.EqualTo(400200));
        }

        [Test]
        public void DecreseStock_Input22_True()
        {
            var product = new Product(43, "Milk", 540.0m, 22);
            product.StockCountDecrease(10);
            var stock = product.Stock;
            Assert.That(stock, Is.EqualTo(12));
        }

        [Test]
        public void DecreseStock_Input45_True()
        {
            var product = new Product(10, "Milk", 310.0m, 45);
            product.StockCountDecrease(-10);
            var stock = product.Stock;
            Assert.That(stock, Is.EqualTo(45));
        }

        [Test]
        public void DecreseStock_Input34_True()
        {
            var product = new Product(25, "Milk", 130.0m, 34);
            product.StockCountDecrease(0);
            var stock = product.Stock;
            Assert.That(stock, Is.EqualTo(34));
        }
    }
}
