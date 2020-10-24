using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softdrinks
{
    class Drink : Product, IFridge
    {
        public float Size { get; set; }
        public override string Name { get; set; }
        public override string Type { get; set; }
        public override decimal Price { get; set; }

        public Drink(string name, string type, float size, decimal price)
        {
            Name = name;
            Type = type;
            Size = size;
            Price = price;
        }


        public override void ShowDetails()
        {
            Console.WriteLine($"Drink | {Name, -10} Type: {Type,-10} Size: {Size, -10} Price: {Price, -10} ");
        }

        public void OutputFridge() {
            Console.WriteLine("Item in the fridge.");
        }


        public override void PriceGreaterThan_08m(bool a)
        {
            if (a) Console.WriteLine($"Name: {Name,-10}Type: {Type,-10}Size: {Size,-10}Price: {Price,-10}");
        }
    }
}
