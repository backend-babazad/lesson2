using System.Runtime.ConstrainedExecution;
using System.Text;

namespace tapsiriq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("1-ci sualin helli");
            //Konsol();

            //Console.WriteLine("2-ci sualin helli");
            //OddNumbers();

            //Console.WriteLine("3-cu sualin helli");
            //reversnumber();

            //Console.WriteLine("4-cu sualin helli");
            //Console.WriteLine(SumNumber());

            //Console.WriteLine("5-ci sualin helli");
            //Faktorial();

            //Console.WriteLine("6-ci sualin helli");
            //SimpleOrComplex();


            //Console.WriteLine("7-ci sualin helli");
            //Cevrilis();

            //Console.WriteLine("8-ci sualin helli");
            //Console.WriteLine(fibonaci());

            //Console.WriteLine("9-ci sualin helli");
            //sum100();

            //Console.WriteLine("10-cu sualin helli");
            //numberseven();


            //Console.WriteLine("1-ci sualin helli for");
            //Ucbucaq();

            // 2-ci sual for
            int var1 = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < var1; i++)
            {
                int sum = 0;
                string var2 = i.ToString();
                for (int j = 0; j < var2.Length; j++)
                {
                    sum += (int)var2[j] * (int)var2[j] * (int)var2[j];
                    Console.WriteLine((int)var2[j]);
                }

            }




            //// 3-cu sual for

            //Console.Write("n daxil edin: ");
            //int n = int.Parse(Console.ReadLine());

            //int count = 0;
            //int row = 1;


            //while (count + row <= n)
            //{
            //    Console.WriteLine(new string('*', row));
            //    count += row;
            //    row--;
            //}


            //Console.WriteLine("4-cu sualin helli for");
            //SadeVeMurekkeb();

            //Console.WriteLine("5-ci sualin helli for");
            //binaryCode();

            //Console.WriteLine("6-ci sualin helli for");
            //Console.WriteLine("while-da islemisdim deye dediniz forda ehtiyac yoxdur for serf etmir cunki");

            //Console.WriteLine("7-ci sualin helli for");
            //Console.WriteLine("dersde etmisdik);

            //Console.WriteLine("8-ci sualin helli for  TAM HELL OLUNMAYIB");
            //differentNumber();
            //differentNumber2();

            //int var1 = Convert.ToInt32(Console.ReadLine());
            //if (IsUnique(var1))
            //{
            //    Console.WriteLine("unikaldir");
            //}
            //else
            //{
            //    Console.WriteLine("Unikal deyil");
            //}


            //9 - cu sual

        }

        static bool IsUnique(int var1)
        {
            string varString = var1.ToString();
            bool isUnique = true;
            for (int i = 0; i < varString.Length; i++)
            {
                for (int j = 0; j < varString.Length; j++)
                {
                    if (i != j && varString[i] == varString[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
            }
            return isUnique;
        }
        static void differentNumber2()
        {
            int count = 0;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a + 1; i < b; i++)
            {
                IsUnique(i);
                if (IsUnique(i))
                {
                    count++;
                    //Console.WriteLine(i);
                }
            }
            Console.WriteLine(count);
        }

        static int Konsol()
        {
            int eded = 0;

            int n = Convert.ToInt32(Console.ReadLine());

            while (n > eded)
            {
                eded++;
                Console.WriteLine(eded);
            }
            return eded;
        }
        static int OddNumbers()
        {
            int eded = 0;

            int n = Convert.ToInt32(Console.ReadLine());

            while (n > eded)
            {
                eded++;
                if (eded % 2 == 1)
                {

                    Console.WriteLine(eded);
                }
            }
            return eded;
        }


        static int Faktorial()
        {
            int eded = 1;
            int hasil = 1;

            int n = Convert.ToInt32(Console.ReadLine());

            while (n >= eded)
            {

                hasil = hasil * eded;
                eded++;
            }
            Console.WriteLine(hasil);
            return hasil;
        }


        static int SimpleOrComplex()
        {
            int eded = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                // Console.WriteLine(hasil);
                if (n % n == 0 && n % 1 == 0)
                {
                    Console.WriteLine("n sade ededdir");
                }
                else
                {
                    Console.WriteLine("n murekkeb ededdir");
                }
                break;
            }
            return n;
        }

        static int Cevrilis()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            while (a >= b)
            {
                Console.WriteLine(a);
                a--;
            }
            return a;
        }

        static int Ucbucaq()
        {
            Console.Write("n daxil edin: ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int row = 1;
            while (count + row <= n)
            {
                Console.WriteLine(new string('*', row));
                count += row;
                row++;
            }
            return row;
        }

        
        static int SadeVeMurekkeb()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool isSimple = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    isSimple = false;
                    break;
                }
            }

            if (isSimple)
            {
                Console.WriteLine("Sadedir");
            }
            else
            {
                Console.WriteLine("murekkebdir");
            }
            return n;
        }


        static int binaryCode()
        {
            int qaliq = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                qaliq = n % 2;
                n = n / 2;
                Console.Write(qaliq);
            }
            return qaliq;
        }
        static void differentNumber()
        {
            int count = 0;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = a + 1; i < b; i++)
            {
                int tam = i;
                int qaliq;
                int cem = 0;
                while (tam > 0)
                {

                    qaliq = tam % 10;
                    tam = tam / 10;
                    cem = cem + qaliq;
                }
                Console.WriteLine(cem);
            }
        }
        static int SumNumber(){
            int cem = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 0)
            {
                cem = cem + n % 10;
                n = n / 10;
            }
            return cem;
        }


        static int fibonaci()
        {
            int preview = 0;
            int next = 1;
            int n = Convert.ToInt32(Console.ReadLine());
            while (n > 1)
            {
                next = preview + next;
                preview = next - preview;
                n--;
            }
            return next;
        }


        static int reversnumber()
        {
            Console.WriteLine("Hello, Cavid!");
            int eded=1;
            int n = Convert.ToInt32(Console.ReadLine());

            while (n > 0)
            {
                eded = n % 10;
                n = n / 10;
                Console.Write(eded);
            }
            return eded;
        }



        static int sum100()
        {
            int cem = 0;
            int a;
            do
            {

                a = Convert.ToInt32(Console.ReadLine());
                cem += a;
                //Console.WriteLine(cem);

            }
            while (cem <= 100);
            return cem;
        }

        static int numberseven()
        {
            Console.WriteLine("Hello, Cavid!");
            int eded = 1;
            int n;

            while (eded != 7)
            {
                n = Convert.ToInt32(Console.ReadLine());
                eded = n % 10;
                n = n / 10;
                //Console.Write(eded);
            }
            return eded;
        }
    }
}
