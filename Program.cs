using EntendendoAlgoritmos.Services;
using System;

namespace EntendendoAlgoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 1, 2, 3, 4, 7, 10, 23, 45, 35, 66 };

            Console.WriteLine("\nO valor está na posição: " + PesquisaBinaria.Pesquisa(ints, 23));
        }
    }
}