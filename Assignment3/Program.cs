using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            int[] toCount = new int[] { 1, 2, 3, 3, 4, 4 };
            CountElement(toCount);

            //Task2
            int[] toSeparate = new int[] { 1, 4, 5, 6, 7, 8, 9 };
            SeparateOdd(toSeparate);

            //Task3
            int[] toDelete = new int[] { 1, 2, 3, 5, 6, 7 };
            RemoveAt(toDelete, 3);
            foreach(int i in toDelete)
            {
                Console.Write($"{i}, ");
            }
        }



        public static void CountElement(int[] intArray)
        {
            List<int> elements = new List<int> { intArray[0] };
            foreach(int num in intArray)
            {
                if (!elements.Contains(num))
                {
                    elements.Add(num);
                }

            }
            foreach (int i in elements)
            {
                int count=0;
                foreach (int element in intArray)
                {
                    if (element==i)
                    {
                        count++;
                    }
                }
                Console.WriteLine($"{i}: {count}");
            }
        }

        public static void SeparateOdd(int[] array)
        {
            List<int> oddList = new List<int>();
            List<int> evenList = new List<int>();
            List<int> toSep = new List<int>(array) ;

            //separate with divided by 2, then add into list
            foreach(int num in toSep)
            {
                if (num%2==0)
                {
                    evenList.Add(num);
                }
                else
                {
                    oddList.Add(num);
                }
            }

            //output
            int[] oddInt = oddList.ToArray();
            foreach (int i in oddInt)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            int[] evenInt = evenList.ToArray();
            foreach (int i in evenInt)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }

        public static void RemoveAt(int[] source, int index)
        {
            index--;
            int[] copy= new int[source.Length-1];
            if (index==0)
            {
                Array.Copy(source, 1, copy, 0, source.Length - 1);
            }
            else if (index>0 && index<source.Length)
            {
                Array.Copy(source, 0, copy, 0, index);
                Array.Copy(source, index + 1, copy, index, source.Length - 1-index);
            }
            source = copy;
        }
    }
}
