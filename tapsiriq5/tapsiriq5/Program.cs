using static System.Net.Mime.MediaTypeNames;

namespace Lessons10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Hasil(5,4,4,7));
            //Bigger(2,3,5,-6,0,9);
            //Even(2,3,5,-6,0,9,222);

            //var var1 = 20;
            //Console.WriteLine(Ref(ref var1));
            //Console.WriteLine(var1);

            //string var2 = Console.ReadLine();
            //Ref2(ref var2);
            //Console.WriteLine( var2);

            //int var3 = Convert.ToInt32(Console.ReadLine());
            //Ref3(ref var3);
            //Console.WriteLine(var3);

            //var var3 = Tf(10, out bool a);
            //Console.WriteLine(var3);


            //var var3 = Tf2(10, out bool a);
            //Console.WriteLine(var3);

            //var var3 = Tf3(10, out bool a);
            //Console.WriteLine(var3);




            // 1 olculu massivlerden qalan suallar: 1,12,15,16,19,20;
            // 2 olculu massivlerden qalan suallar: 2,3,4,5,6,7,8,9,10;
            // for dovrune aid suallar: 2,9,10;

        }


        static int Hasil(params int[] num1)
        {
            int hasil = 1;
            for (int i = 0; i < num1.Length; i++)
            {
                hasil*= num1[i];
            }
            return hasil;
        }
        static void Bigger(params int[] num1)
        {
            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i] >0)
                {
                    Console.WriteLine(num1[i]);
                }
            }
        }
        static void Even(params int[] num1)
        {
            for (int i = 0; i < num1.Length; i++)
            {
                if (num1[i]%2==0)
                {
                    Console.WriteLine(num1[i]);
                }
            }
        }

        static int Ref(ref int a)
        {
            a *= 10;
            return a;
        }
        static string Ref2(ref string a)
        {
            Console.WriteLine("I will win"+""+a);
            return a;
        }

        static int Ref3(ref int a)
        {
            if (a%2==0 && a>0)
            {
                Console.WriteLine(a+"  "+"Proqram isliyir");
            }
            else
            {
                Console.WriteLine("Proqram islemir");
            }
                return a;
        }
        static int Tf(int var1,out bool isOk)
        {
            if (var1>0)
            {
                isOk = true;
                return var1 * 10;
            }
            else
            {
                isOk = false;
                return var1;
            }
        }

        static int Tf2(int var1, out bool isOk)
        {
            if (var1 > 0)
            {
                isOk = true;
                return var1 * var1;
            }
            else
            {
                isOk = false;
                return var1*2;
            }
        }
        static void Tf3(int var1, out bool isOk)
        {
            if (var1%2==0 && var1>0)
            {
                isOk = true;
                for (int  i = 0; i < 100; i++)
                {
                    Console.WriteLine(i);
                }
                
            }
            else
            {
                isOk = false;               
            }
        }
    }
}