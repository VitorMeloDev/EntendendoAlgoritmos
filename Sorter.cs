using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos
{
    class Sorter
    {
        public static void ArraySelectionSort(int[] list, bool BigToSmall)
        {
            int count = list.Length;

            for (int i = 0; i < count; i++)
            {
                int min = i;

                for (int j = i + 1;  j < count; j++)
                {
                    if(BigToSmall)
                    {
                        if (list[j] > list[i])
                        {
                            SwitchOrder(list, i, j);
                        }
                    }
                    else
                    {
                        if (list[j] < list[i])
                        {
                            SwitchOrder(list, i, j);
                        }
                    }
                }
            }
        }

        static void SwitchOrder(int[] list, int a, int b)
        {
            int x = list[a];
            list[a] = list[b];
            list[b] = x;
        }

        public static void PrintList(int[] list)
        {
            Console.Write("[ ");
            for (int i = 0;i < list.Length;i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine("]");
        }
    }
}
