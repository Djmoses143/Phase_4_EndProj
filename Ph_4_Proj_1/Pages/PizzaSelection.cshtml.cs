using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Ph_4_Proj_1.Pages
{
    [BindProperties]
    public class PizzaSelectionModel : PageModel
    {

        public List<SelectListItem> PizzaTypes { get; } = new List<SelectListItem>
    {
        new SelectListItem("Margherita", "Margherita"),
        new SelectListItem("Pepperoni", "Pepperoni"),
        new SelectListItem("Chicken", "Chicken")
    };

        public string pizzaname { get; set; }
        public int Quantity { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/OrderCheckout", new OrderCheckoutModel { PizzaName = pizzaname, Quantity = Quantity });
        }
    }
}