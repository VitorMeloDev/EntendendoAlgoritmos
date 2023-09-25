using EntendendoAlgoritmos.Services;
using System;

namespace EntendendoAlgoritmos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 7, 3, 1, 9, 5, 2, 8, 4, 6 };
            int[] list2 = { };

            int x = Calculos.Somar(list);
            Console.WriteLine("Soma: " + x);
            Console.WriteLine("Valores na coleção: " + Calculos.Conta(list));
        }
    }
}