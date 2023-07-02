using JustPizza.Data;
using JustPizza.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JustPizza.Pages.Checkouts
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string ImageTitle { get; set; }
        public string Name { get; set; }
        public float PizzaPrice { get; set; }
              

        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(Name))
            {
                Name = "Free Choice";

            }
            if(string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "~/Images/Create.png";
            }
           
           
        }
        public IActionResult OnPost()
        {
            
            return RedirectToPage("/Checkouts/ThankYou", new { Name, PizzaPrice });
        }


    }
}
