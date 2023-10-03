using System;
using System.Collections.Generic;

namespace EntendendoAlgoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 7, 3, 25, 9, 5, 2, 8, 4, 6 };

            Console.WriteLine("Lista Ordenada do Maior para Menor: ");
            Sorter.ArraySelectionSort(list, true);
            Sorter.PrintList(list);

            Console.WriteLine("\nLista Ordenada do Menor para Maior: ");
            Sorter.ArraySelectionSort(list, false);
            Sorter.PrintList(list);
        }
    }
}