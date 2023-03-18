using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace delegates_sharp_hw
{
    public delegate int delFunc  (int[] array);
    internal class Program
    {
        class Func
        {
            public int sumArr(int[] ar)
            {
                int sum = 0;
                for (int i = 0; i < ar.Length; i++)
                {
                    sum += ar[i];
                }
                Write("Сумма элементов массива: ");
                return sum;
                
            }

            public int maxElArr(int[] ar)
            {
                int res = 0;
                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] > res)
                      res = ar[i];
                }
                Write("Максимальный элемент массива: ");
                return res;
                
            }

            public int divideByTwoArr(int[] ar)
            {
                int res = 0;
                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] > res)
                        res = ar[i];
                }
                Write("Максимальный элемент массива / 2: ");
                return res / 2;
                
            }
        }

        static void Main(string[] args)
        {
            Func f = new Func();
            Random r = new Random();

            delFunc arrdel = null;

            

            int[] arr = new int[10];

            Write("Изначальный массив: ");
            for (int i = 0; i < arr.Length; i++)
            {            
                Write($"{arr[i] = r.Next(100)} ");
            }
            WriteLine();


            arrdel = f.sumArr;
            WriteLine();

            arrdel += f.maxElArr;
            arrdel += f.divideByTwoArr;


            foreach (delFunc item in arrdel.GetInvocationList())
            {
                WriteLine(item(arr));
                
            }

            arrdel -= f.divideByTwoArr;

            WriteLine();
            WriteLine("ОТПИСКА");
            WriteLine();

            foreach (delFunc item in arrdel.GetInvocationList())
            {
                WriteLine(item(arr));

            }
        }
    }
}
