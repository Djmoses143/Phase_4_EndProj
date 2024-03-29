using Microsoft.AspNetCore.Mvc;
using Ph_4_Proj_1.Pages;

namespace NUnitLib
{
    [TestFixture]
    public class PizzaOrderTests
    {
        [Test]
        public void PizzaSelectionPage_ShouldReturnPageResult()
        {
            // Arrange
            var pizzaPageModel = new PizzaSelectionModel();

            // Act
            var result = pizzaPageModel.OnPost();

            // Assert
            Assert.IsInstanceOf<RedirectToPageResult>(result);
            var redirectResult = (RedirectToPageResult)result;
            Assert.AreEqual("/OrderCheckout", redirectResult.PageName);
        }

        [Test]
        public void OrderCheckoutPage_ShouldReturnPageResult()
        {
            // Arrange
            var orderCheckoutModel = new OrderCheckoutModel
            {
                PizzaName = "Pepperoni",
                Quantity = 2
            };

            // Act
            var result = orderCheckoutModel.OnPost();

            // Assert
            Assert.IsInstanceOf<RedirectToPageResult>(result);
            var redirectResult = (RedirectToPageResult)result;
            Assert.AreEqual("/OrderConfirmation", redirectResult.PageName);
        }

        // Add more test methods as needed to cover different scenarios
    }

}