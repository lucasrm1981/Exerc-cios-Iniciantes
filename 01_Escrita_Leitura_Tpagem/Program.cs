using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
/* Exibicao de valores passados diretamente para as variáveis */

                /* Pelo fato de ser fortemente tipado temos variações mesmo na variável com o nome igual
                 */
                int num = 0, Num = 1, nUm = 3, nuM = 4;
                Console.WriteLine("num " + num + " Num " + Num + " nUm " + nUm + " nuM " + nuM);
          
          Console.WriteLine("\n -------------------------------------- \n");

                string nome = "Lucas Rodrigues Monteiro";
                int idade = 42;
                for (int i = 0; i < nome.Length; i++)
                {
                    Console.WriteLine("A letra é " + nome[i] + " Posição " + i);
                }

                Console.WriteLine("idade " + idade);
            }
        }
}