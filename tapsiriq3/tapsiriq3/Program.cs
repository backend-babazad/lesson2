using System.Diagnostics;

namespace tapsiriq3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1-ci sual
            //Console.WriteLine("3-cu sualin helli");
            //edediOrta();
            //Console.WriteLine("4-cu sualin helli");
            //sum();

            //Console.WriteLine("2-ci sualin helli");
            //int[] arrays = new int[Convert.ToInt32(Console.ReadLine())];
            //for (int i = 0; i < arrays.Length; i++)
            //{
            //    Console.WriteLine("massivin  " + i + "ci indeksindeki ededi daxil et");
            //    arrays[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = arrays.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(arrays[i]);
            //}


            // 5-ci sual
            //massiv();

            // 6-ci sual
            //int[] array = { 3, 5, 2, 6, 1, 7, 8 };

            //for (int i = 0; i < array.Length; i++)
            //{
            //    for (int j = 0; j < array.Length; j++)
            //    {
            //        if (array[i] > array[j])
            //        {
            //            int a = array[i];
            //            array[i] = array[j];
            //            array[j] = a;
            //        }
            //    }
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}


            //Console.WriteLine("7-ci sualin helli");
            //inOrOut();

            //Console.WriteLine("8-ci sualin helli");
            //vur2();

            // 9-cu 
            //int[] arrays = new int[Convert.ToInt32(Console.ReadLine())];
            //for (int i = 0; i < arrays.Length; i++)
            //{
            //    arrays[i] = Convert.ToInt32(Console.ReadLine());
            //}

            // 18-ci sual
            //int cem = 0;
            //int[] massiv = new int[3];
            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    massiv[i] = Convert.ToInt32(Console.ReadLine());
            //    for (int j = 0; j < massiv.Length; j++)
            //    {
            //    cem += i;

            //    }
            //}
            //for (int i = 0; i < massiv.Length; i++)
            //{
            //    Console.Write(massiv[i]);
            //    Console.WriteLine(cem);
            //}

            // 19-cu sual  aydaaaaaaaaaaaaaa

            // 17-ci sual yazmisam yenede kicik bir error var
            //cutIndex();

            // 11-ci sual
            //int[] x = { 5, 10, 25, 75 };
            //for (int i = 0; i < x.Length; i++)
            //{
            //    if (i != 0)
            //    {
            //        int y = x[i] / x[i - 1];
            //        Console.WriteLine(y);
            //    }
            //}

            // 12-ci sual
            //int[] initArr = { 1, 4, 8, 23, 12, 8 };
            //List<int> resArr = new List<int> { };

            //for (int x = 0; x < initArr.Length; x++)
            //{ 
            //    int count = 0;
            //    int sum = 0;
            //    for (int y = x; y < initArr.Length; y++)
            //    {
            //        sum += initArr[y];
            //        count++;

            //        if (count == 3)
            //        {
            //            resArr.Add(sum);
            //            break;   
            //        }
            //    }

            //    x++;
            //}

            //Console.WriteLine(resArr.Max());


            // 13-cu sual
            //int say = 0;
            //int[] x = { 1, 4, 8, 23, 12, 8 };
            //for (int i = 0; i < x.Length; i++)
            //{
            //    if (i != 0) { 
            //        if (x[i] % x[i-1]==0)
            //        {
            //            say++;
            //        }
            //    }
            //}
            //            Console.WriteLine(say);


            // 14-cu sual
            //int[] x = { 3, 9, 5, 2, 12, 16 };
            //int say = 0;
            //for (int i = 0; i < x.Length; i++)
            //{
            //    if (i>0)
            //    {

            //    if (x[i] > x[i-1])
            //    {
            //        say++;
            //    }
            //    }

            //}
            //Console.WriteLine(say);


            // 10-cu sual
            //int[] x = { 12, 11, 12, 22, 27, 23, 62, 23 };
            //for (int i = 0; i < x.Length; i++)
            //{
            //    int say = 0;
            //    for (int j = 0; j < x.Length;  j++)
            //    {
            //    if (x[i] == x[j])
            //    {
            //        say++;
            //    }
                    
            //    }
            //    //i++;
            //        Console.WriteLine(say);
            //}



        }
        static int edediOrta()
        {
            int cem = 0;
            int average;
            int[] arrays = new int[4];
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine("massivin  " + i + "ci indeksindeki ededi daxil et");
                arrays[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arrays.Length; i++)
            {
                cem = cem + arrays[i];
            }
            average = cem / arrays.Length;
            Console.WriteLine(average);
            return average;
        }


        static int sum()
        {
            int cem = 0;
            int[] arrays = new int[4];
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine("massivin  " + i + "ci indeksindeki ededi daxil et");
                arrays[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arrays.Length; i++)
            {
                cem = cem + arrays[i];
            }
            Console.WriteLine(cem);
            return cem;
        }


        static int inOrOut()
        {
            int[] arrays = new int[4];
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine("massivin  " + i + "ci indeksindeki ededi daxil et");
                arrays[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("bir eded daxil edin yoxlayaq");
            int a = Convert.ToInt32(Console.ReadLine());

            if (arrays.Contains(a))
            {
                Console.WriteLine("bu eded massivde var");
            }
            else
            {
                Console.WriteLine("yoxdur");
            }
            return a;
        }


        static int vur2()
        {
            int[] arrays = new int[4];
            for (int i = 0; i < arrays.Length; i++)
            {
                Console.WriteLine("massivin  " + i + "ci indeksindeki ededi daxil et");
                arrays[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(arrays[i] * 2);
            }
            return arrays[4];
        }



        static int massiv()
        {
            int[] massiv = { 5, 3, 8, 1, 4 };

            int enKicik = massiv.Min();
            int indeks = Array.IndexOf(massiv, enKicik);
            Console.WriteLine(indeks);

            return indeks;
        }
        static void cutIndex()
        {
            int[] massiv = new int[6];
            for (int i = 0; i < massiv.Length; i++)
            {
                massiv[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < massiv.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(massiv[i]);
                }

            }

        }

    }
}
