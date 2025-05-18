namespace tapsiriq8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1 olculu massivlerden qalan suallar: 12,15,16,19,20;
            // 2 olculu massivlerden qalan suallar: 2,3,4,5,6,7,8,9,10;
            // for dovrune aid suallar: 2,9,10;

            //Test1();
            //Test2();
            //Test3();
            //Test4();


            //Console.WriteLine("19-cu sualin helli massivler");
            //int qismet=1;
            //int[] array = new int[6];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //    for (int j = 0; j < array[i]; j++)
            //    {
            //        if (array[i] > array[j])
            //        {
            //            Console.WriteLine(array[i]);  
            //        }
            //    }
            //}




        }


        static void Test1()
        {
            Console.WriteLine("2-ci sualin helli");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < a; i++)
            {
                int m = i % 10;
                int n = i / 10;
                int z = i / 10;
                if (n > 0 && m > 0 && z > 0)
                {

                    if (Math.Pow(m, 3) + Math.Pow(n, 3) + Math.Pow(z, 3) == i)
                    {
                        int c = i;
                        Console.WriteLine(c);
                    }
                }
            }
        }


        static void Test2()
        {
            Console.WriteLine("9-cu sualin helli");
            int a = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    sum += i;
                    if (sum == a)
                    {
                        Console.WriteLine(a);
                        Console.WriteLine("Eded mukemmeldir");
                    }
                    else
                    {
                        Console.WriteLine("eded mukemmel deyil");
                    }
                }
            }
        }


        static void Test3()
        {
            Console.WriteLine("12-ci sualin helli massivler");
            int sum1 = 0;
            int sum2 = 0;

            int[] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i < 3)
                {
                    sum1 += array[i];
                }
                else if (i >= 3 && i < 6)
                {
                    sum2 += array[i];
                }
            }

            Console.WriteLine(Math.Max(sum1, sum2));
        }

        static void Test4()
        {
            Console.WriteLine("19-cu sualin helli massivler");
            Console.WriteLine("Axtarilan ededi yazin");
            int search = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }     
            search = Array.IndexOf(array, search);
                  Console.WriteLine(search);


        }





    }
}
