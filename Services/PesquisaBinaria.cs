using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntendendoAlgoritmos.Services
{
    class PesquisaBinaria
    {
        public static int Pesquisa(int[] list, int item) // Aqui darei a lista e o item a ser buscado
        {
            // Baixo e Alto acompanham os dois extremos da lista, o menor e maior valor
            int baixo = 0;
            int alto = list.Length - 1;
            int ciclo = 1;

            while (baixo <= alto)
            {

                Console.WriteLine("Ciclo " + ciclo);

                int meio = (baixo + alto) / 2;
                Console.WriteLine("Meio de "+ baixo + " e " + alto + ": " + meio);

                double chute = list[meio];
                Console.WriteLine("O VALOR PARA O CHUTE É: " + chute);

                if (chute == item)
                {
                    return meio;
                }

                if(chute > item)
                {
                    Console.Write("Chute foi alto, incrementando a variavel ALTO de: " + alto + ", para: ");
                    alto = meio - 1;
                    Console.WriteLine(alto);
                }
                else
                {
                    Console.Write("Chute foi baixo, incrementando a variavel BAIXO de: " + baixo + ", para: ");
                    baixo = meio + 1;
                    Console.WriteLine(baixo);
                }

                ciclo++;
                Console.WriteLine();
            }
            return -1;
        }
    }
}
