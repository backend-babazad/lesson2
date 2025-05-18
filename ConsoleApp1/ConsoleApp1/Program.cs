namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ulduz = "*";
            int say=Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < say; i++)
            {
                Console.WriteLine(ulduz);
                ulduz += "*";
                if (ulduz=="6")
                {
                    Console.WriteLine("ucbucaq quruldu");
                }
            }
        }

    }
}
