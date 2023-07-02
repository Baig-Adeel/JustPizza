namespace JustPizza.Model
{
    public class PizzasModel
    { 
        public string ImageURL { get; set; }
        public string Name { get; set; }
        public float BasePrice { get; set; } = 2;
        public float FinalPrice { get; set; }
        public bool Cheese { get; set; }
        public bool Mushrooms { get; set; }
        public bool Peppers { get; set; }
        public bool Tuna { get; set; }
        public bool Pineapple { get; set; }
        public bool Peperoni { get; set; }
        public bool Ham { get; set; }
    }
}
