using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tapsiriq7.Model
{
    class Mercedes : Cars 
    {
      public  string yanacaq;
        int cost;
        public Mercedes(string name, int year, int cost,string color) : base(name, year,cost,color)
        {
            this.cost = cost;
            yanacaq = "Benzin";
        }
        public void  Melumat()
        {
            Console.WriteLine("Car's name: " + name);
            Console.WriteLine("Car's year: " + year);
            Console.WriteLine("Car's yanacaq: " + yanacaq);
            Console.WriteLine("Car's cost: " + cost);
        }
        
    }
}
