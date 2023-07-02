using JustPizza.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Net.Mime.MediaTypeNames;

namespace JustPizza.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        { 
            new PizzasModel(){
                ImageURL = "~/Images/Bolognese.png",
                Name = "Bolognese",
                BasePrice = 2,
                FinalPrice = 5,
                Cheese = true,
                Mushrooms = true,
                Peppers = true},
            new PizzasModel(){ImageURL = "~/Images/Carbonara.png", Name = "Carbonara", BasePrice = 2, FinalPrice = 5, Cheese = true, Mushrooms = true, Ham = true},
            new PizzasModel(){ImageURL = "~/Images/Hawaiian.png", Name = "Hawaiian", BasePrice = 2, FinalPrice = 6, Cheese = true, Mushrooms = true, Ham = true, Peperoni=true},
            new PizzasModel(){ImageURL = "~/Images/Margerita.png", Name = "Margerita", BasePrice = 2, FinalPrice = 2},
            new PizzasModel(){ImageURL = "~/Images/MeatFeast.png", Name = "MeatFeast", BasePrice = 2, FinalPrice = 5, Cheese = true, Peperoni = true, Ham = true},
            new PizzasModel(){ImageURL = "~/Images/Mushroom.png", Name = "Mushroom", BasePrice = 2, FinalPrice = 4, Cheese = true, Mushrooms = true},
            new PizzasModel(){ImageURL = "~/Images/Pepperoni.png", Name = "Pepperoni", BasePrice = 2, FinalPrice = 4, Cheese = true, Peperoni = true},
            new PizzasModel(){ImageURL = "~/Images/SeaFood.png", Name = "Seafood", BasePrice = 2, FinalPrice = 5, Cheese = true, Mushrooms = true, Tuna = true},
            new PizzasModel(){ImageURL = "~/Images/Vegetarian.png", Name = "Vegetarian", BasePrice = 2, FinalPrice = 6, Cheese = true, Mushrooms = true, Peppers = true,Pineapple = true},
        };
        public void OnGet()
        {
        }
    }
}
