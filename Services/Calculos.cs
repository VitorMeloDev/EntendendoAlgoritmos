using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Services
{
    class Calculos
    {
        // Dividir para conquistar. Aqui uso de recursão para realizar a soma de uma list.
        public static int Somar(int[] list)
        {
            if(list.Length == 0) return 0;

            return list[0] + Somar(list[1..]);
        }


        // Aqui uso recursão para buscar quantos itens tem em um array
        public static int Conta(int[] list)
        {
            if (list.Length == 0) { return 0; }

            return 1 + Conta(list[1..]);
        }

        public static int Maior(int[] list)
        {
            if (list.Length == 0) { throw new ArgumentException("A lista está vazia"); }

            int x = list[0];

            for (int i = 1; i < list.Length; i++)
            {
                if (list[i] > x) { x = list[i];}
            }

            return x;
        }
    }
}
