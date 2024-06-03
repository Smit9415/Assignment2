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
        public void Method7_Price_WithinRange()
        {
            var product = new Product(64, "Product1", 345.0m, 43);
            var price = product.Price;
            Assert.That(price, Is.InRange(4, 40000));
        }

        [Test]
        public void Method8_Price_True()
        {
            var product = new Product(10, "Product1", 40.0m, 10);
            var price = product.Price;
            Assert.That(price, Is.EqualTo(40.0m));
        }

        [Test]
        public void Method9_Price_NotNullOrEmpty()
        {
            var product = new Product(10, "Product1", 230.0m, 10);
            var price = product.Price;
            Assert.That(price, Is.Not.Null.Or.Empty);
        }
    }
}
