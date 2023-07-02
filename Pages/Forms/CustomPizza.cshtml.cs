using JustPizza.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JustPizza.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel pizza { get; set; }
        public float PizzaPrice { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            PizzaPrice = pizza.BasePrice;

            if (pizza.Cheese) PizzaPrice += 1;
            if (pizza.Peppers) PizzaPrice += 1;
            if (pizza.Peperoni) PizzaPrice += 1;
            if (pizza.Tuna) PizzaPrice += 1;
            if (pizza.Ham) PizzaPrice += 1;
            if (pizza.Pineapple) PizzaPrice += 1;
            if (pizza.Mushrooms) PizzaPrice += 1;

            return RedirectToPage("/Checkouts/Checkout", new { pizza.Name, PizzaPrice });
        }
    }
}
