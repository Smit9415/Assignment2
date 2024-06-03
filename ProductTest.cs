using NUnit.Framework;

namespace assignment.Tests
{
    [TestFixture]
    public class ProductTests
    {
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
