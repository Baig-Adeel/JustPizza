using JustPizza.Data;
using JustPizza.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace JustPizza.Pages.Checkouts
{
    [BindProperties(SupportsGet = true)]
    public class ThankYouModel : PageModel
    {
        public string Name { get; set; }
        public float PizzaPrice { get; set; }
        private readonly ApplicationDbContext _context;
        public ThankYouModel(ApplicationDbContext context)
        {
            _context= context;
        }
        public void OnGet()
        {
            PizzaOrder pizzaOrder = new PizzaOrder();
            pizzaOrder.PizzaName = Name;
            pizzaOrder.FinalPrice = PizzaPrice;
            try
            {
                _context.PizzaOrders.Add(pizzaOrder);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
