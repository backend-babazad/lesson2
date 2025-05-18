using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq7.Model
{
    class Cars
    {
        public string name;
        public int year;
        public int cost;
        public string color;
       public  Cars(string name_,int year_,int cost_,string color_)
        {
            this.name = name_;
            this.year = year_;
            this.cost = cost_;
            this.color = color_;
        }
        public string Fire()
        {
            Console.WriteLine("Car's name: "+name);
            Console.WriteLine("Car's year: " + year);
            Console.WriteLine("Car's cost: " + cost);
            Console.WriteLine("Car's color: " + color);
            return " Muherrik ise dusdu ";
        }
    }
}
