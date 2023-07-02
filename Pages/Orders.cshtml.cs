using JustPizza.Data;
using JustPizza.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace JustPizza.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaOrder> pizzaOrders = new List<PizzaOrder>(); 
        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context= context;
        }
        public void OnGet()
        {
            pizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
