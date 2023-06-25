using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle="Margerita",
                PizzaName="Margerita",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=false,
                Mushroom=false,
                Pineapple=false,
                Ham=false,
                Beef=false,
                FinalPrice=4
            },
            new PizzasModel()
            {
                ImageTitle="Bolognese",
                PizzaName="Bolognese",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=false,
                Mushroom=false,
                Pineapple=false,
                Ham=false,
                Beef=false,
                FinalPrice=4
            },
            new PizzasModel()
            {
                ImageTitle="Carbonara",
                PizzaName="Carbonara",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=false,
                Mushroom=false,
                Pineapple=false,
                Ham=true,
                Beef=false,
                FinalPrice=5
            },
            new PizzasModel()
            {
                ImageTitle="Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                Mushroom=false,
                Pineapple=true,
                Ham=true,
                Beef=true,
                FinalPrice=16
            },
            new PizzasModel()
            {
                ImageTitle="MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                Mushroom=false,
                Pineapple=false,
                Ham=true,
                Beef=true,
                FinalPrice=7
            },
            new PizzasModel()
            {
                ImageTitle="Mushroom",
                PizzaName="Mushroom",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=false,
                Mushroom=true,
                Pineapple=false,
                Ham=false,
                Beef=false,
                FinalPrice=5
            },
            new PizzasModel()
            {
                ImageTitle="Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=true,
                Mushroom=false,
                Pineapple=false,
                Ham=false,
                Beef=false,
                FinalPrice=5
            },
            new PizzasModel()
            {
                ImageTitle="Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=2,
                TomatoSauce=true,
                Cheese=true,
                Pepperoni=false,
                Mushroom=true,
                Pineapple=false,
                Ham=false,
                Beef=false,
                FinalPrice=5
            },
        };
        public void OnGet()
        {
        }
    }
}
