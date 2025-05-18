using tapsiriq7.Model;

namespace tapsiriq7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars car1 = new Cars("Toyota",2011,22000,"White");
            Mercedes mercedes1 = new Mercedes("Mercedes",2011,2000,"Black");
            car1.Fire();
            mercedes1.Melumat();
        }
    }
}
