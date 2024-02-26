using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ph_4_Proj_1.Pages;

namespace Ph_4_Proj_1.Pages
{
    [BindProperties(SupportsGet = true)]
    public class OrderCheckoutModel : PageModel
    {
        public string? PizzaName { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => Quantity * 10;
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/OrderConfirmation", new OrderConfirmationModel { PizzaName = PizzaName, Quantity = Quantity, TotalAmount = TotalPrice });
        }
    }
}