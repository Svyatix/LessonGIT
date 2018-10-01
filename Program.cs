using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            min_max();
            Console.Write("\n");
            factor();
            Console.Write("\n");
            fibonachi();
            Console.Write("\n");
            bi_quad();
        }
        public static void factor()
        {
            int n = 5;
            int result = 1;
            if (n > 0)
            {
                for (int i = n; i > 1; i--)
                {
                    result = result * i;
                }
                Console.Write(" Факториал=" + result);
                int c = n;
                int result_while = 1;
                while (c > 1)
                {
                    result_while = result_while * c;
                    c--;
                }
                Console.Write(" Факториал(while)=" + result_while);
            }
            else Console.Write("ERROR");
            Console.ReadKey();
        }
        public static void fibonachi()
        {
            int[] fibonachi = new int[3] { 0, 1, 1};
            for (int i = 2; i <= 10; i++)
            {
                Array.Resize(ref fibonachi, fibonachi.Length + 1);
                fibonachi[i] = fibonachi[i - 1]+fibonachi[i-2];
            }
            Console.Write("Введите число фибоначчи ");
            int key = Convert.ToInt32(Console.ReadLine());
            if (key > 0) Console.Write(fibonachi[key]);
            else if (key > 0 && key % 2 == 0) Console.Write(fibonachi[key]);
            else if (key < 0 && key % 2 == 0) Console.Write(fibonachi[key*-1] * -1);
            else Console.Write(fibonachi[key*-1]);
            Console.ReadKey();
        }
        public static void min_max()
        {
            int[] array = new int[5] { 1, 4, 5, 10, 25 };
            int max = array[0];
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i]) min = array[i];
                if (max < array[i]) max = array[i];
            }
            Console.Write("max=" + max + " min=" + min);
            int j = 0;
            int max_while = array[0];
            int min_while = array[0];
            while (j < array.Length)
            {
                if (min_while > array[j]) min_while = array[j];
                if (max_while < array[j]) max_while = array[j];
                j++;
            }
            Console.Write(" max_while=" + max_while + " min_while=" + min_while);

            int max_foreach = array[0];
            int min_foreach = array[0];
            foreach (int i in array)
            {
                if (min_foreach > i) min_foreach = i;
                if (max_foreach < i) max_foreach = i;
            }
            Console.Write(" max_foreach=" + max_foreach + " min_foreach=" + min_foreach);
            Console.ReadKey();
        }
        public static void bi_quad()
        {
            Console.Write("Введите тип: (1- квадратное 2-биквадратное) ");
            int type = Convert.ToInt32(Console.ReadLine());
            if (type == 1)
            {
                Console.Write("Введите а ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c ");
                double c = Convert.ToDouble(Console.ReadLine());
                double discriminant = (int)Math.Pow(b, 2) - 4 * a * c;
                double x1 = ((-1 * b) + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = ((-1 * b) - Math.Sqrt(discriminant)) / (2 * a);
                Console.Write("x1= " + x1 + "\n" + "x2= " + x2);
                Console.ReadKey();
            }
            else
            {
                Console.Write("Введите а ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите b ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите c ");
                double c = Convert.ToDouble(Console.ReadLine());
                double discriminant = (int)Math.Pow(b, 2) - 4 * a * c;
                double x1 = ((-1 * b) + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = ((-1 * b) - Math.Sqrt(discriminant)) / (2 * a);
                if (x1 > 0) Console.Write("x1= " + Math.Sqrt(x1)+"\n"+"x1(minus) "+x1*-1);
                if (x2 > 0) Console.Write("\n" + "x2= " + Math.Sqrt(x2)+ "\n"+"x2(minus) "+x2*-1);
                else Console.Write("ERROR");
                Console.ReadKey();
            }
        }
    }
}
