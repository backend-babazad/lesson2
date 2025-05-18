//using System.Runtime.CompilerServices;
//using System.Security.Cryptography.X509Certificates;
//using System.Xml.Linq;

//namespace Lessons11
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            User User1 = new User("Cavid","Babazade",2004,2025);

//        }
//    }

//    class User
//    {
//        public string name;
//        public string surename;
//        public int dogumili;
//        public int indikiil;
//        public int yas;
//        public User(string name, string surename,int dogumili,int indikiil)
//        {
//            this.name = name;
//            this.surename = surename;
//            this.dogumili = dogumili;
//            this.indikiil = indikiil;
//            yas = indikiil - dogumili;
//            Console.WriteLine(name + " " + surename + " " + yas);

//        }


//        public void calculate()
//        {
//            Console.WriteLine(name + " " + surename + " " + yas);
//        }


//    }


//}



using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Lessons11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            User User1 = new User();
            User1.name = "Toyota";
            User1.color = "white";
            User1.ili = 2014;
            User1.qiymeti = 17000;
            User1.calculate();
        }
    }

    class User
    {
        public string name;
        public string color;
        public int ili;
        public int qiymeti;



        public void calculate()
        {
            Console.WriteLine(name + " " + color + " " + ili + " " + qiymeti);
        }


    }


}




