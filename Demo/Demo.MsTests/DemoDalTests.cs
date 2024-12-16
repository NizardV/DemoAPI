using Demo.DAL;

namespace Demo.MsTests
{
    [TestClass]
    public class DemoDalTests
    {
        [TestMethod]
        public void GetCustomers_ShouldReturnCustomers()
        {
            // Arrange
            Data data = new Data();
            // Act
            var result = data.GetCustomers();
            // Assert
            Assert.IsNotNull(result);
        }
    }
}