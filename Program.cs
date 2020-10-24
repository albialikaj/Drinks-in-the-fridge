using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softdrinks
{
    class Program
    {
       
        static void Main(string[] args)
        {
            List<Product> AllProducts = new List<Product>();
            Product Drink1 = new Drink( name: "LemonadeX", type: "Sugar-free", size: 330f, price: 0.85m);
            Product Drink2 = new Drink( name: "Cola", type: "Regular", size: 330f, price: 0.70m);
            Product Drink3 = new Drink( name: "Cola L", type: "Light", size: 330f, price: 0.75m);
            Product Drink4 = new Drink( name: "RedDrink", type: "Energy", size: 330f, price: 0.90m);
            Product Drink5 = new Drink( name: "OrangeX", type: "Regular", size: 330f, price: 0.75m);
            Product Drink6 = new Drink( name: "Fanta", type: "Light", size: 330f, price: 0.85m);
            Product Drink7 = new Drink( name: "Pepsi", type: "Regular", size: 330f, price: 0.75m);
            Product Drink8 = new Drink( name: "Pepsi", type: "Sugar-free", size: 330f, price: 0.80m);
            Product Drink9 = new Drink( name: "Cola", type: "Regular", size: 330f, price: 0.80m);
            Product Drink10 = new Drink(name: "Cola", type: "Light", size: 330f, price: 0.85m);
            Product Drink11 = new Drink(name: "Soda", type: "Sugar-free", size: 330f, price: 0.80m);
            Product Drink12 = new Drink(name: "Peri", type: "Regular", size: 250f, price: 0.95m);
            Product Drink13 = new Drink(name: "Tonic", type: "Energy", size: 330f, price: 0.85m);
            Product Drink14 = new Drink(name: "Zup", type: "Regular", size: 330f, price: 0.80m);
            Product Drink15 = new Drink(name: "Zup", type: "Regular", size: 330f, price: 0.90m);

            AllProducts.Add(Drink1);
            AllProducts.Add(Drink2);
            AllProducts.Add(Drink3);
            AllProducts.Add(Drink4);
            AllProducts.Add(Drink5);
            AllProducts.Add(Drink6);
            AllProducts.Add(Drink7);
            AllProducts.Add(Drink8);
            AllProducts.Add(Drink9);
            AllProducts.Add(Drink10);
            AllProducts.Add(Drink11);
            AllProducts.Add(Drink12);
            AllProducts.Add(Drink13);
            AllProducts.Add(Drink14);
            AllProducts.Add(Drink15);


            Console.WriteLine("\n__All products__");
            foreach (var product in AllProducts)
            {
                product.ShowDetails();
            }


            Console.WriteLine("\n__Products with price greater than 0.8__");
            AllProducts.Where(x => x.Price > 0.8m).ToList().ForEach(x => x.ShowDetails());



            Console.WriteLine("\n__Inside the fridge__");
            Fridge fridge = new Fridge();

            fridge.AllDrinks.Add(Drink1 as Drink);
            fridge.AllDrinks.Add(Drink2 as Drink);
            fridge.AllDrinks.Add(Drink3 as Drink);
            fridge.AllDrinks.Add(Drink4 as Drink);

            foreach (Product item in fridge.AllDrinks)
                {
                    (item as Drink).OutputFridge();

                //Action delegate, so we don't need the delegate void print above
                Action<string, string, float, decimal> del = (a, b, c, d) => Console.WriteLine($"Drink | Name: {a,-10} Type: {b,-10} Size: {c,-10} Price: {d,-10}");
                del(item.Name, item.Type, (item as Drink).Size, item.Price);

                }


            //DISPLAY inside the fridge Drinks values whose Price is greater than 0.8 euro
            Console.WriteLine("\n__Products in the fridge with price greater than 0,8__");
            foreach (Product item in fridge.AllDrinks)
            {
                //Lambda expression & ternary operator
                Predicate<decimal> del = (a) => a > 0.8m ? true : false;
                //if the result is true, Get the values of product
                item.PriceGreaterThan_08m(del(item.Price));
            }
            Console.WriteLine("_________________________________________");
            //END OF DISPLAY ALL 



            decimal averagePrice = AllProducts.Average(x => x.Price);
            Console.WriteLine("The average price is " + averagePrice);

            decimal maxPrice = AllProducts.Max(x => x.Price);
            Console.WriteLine("The max price is " + maxPrice);

            Console.ReadKey();

        }
    }
}
