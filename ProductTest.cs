using NUnit.Framework;

namespace assignment.Tests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void Method1_ProductId_WithinRange()
        {
            var product = new Product(4, "Test Product", 10.99m, 10);
            var productId = product.ProductID;
            Assert.That(productId, Is.InRange(4, 40000));
        }
    }
}
