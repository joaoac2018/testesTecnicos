using System;

namespace questao1
{
    class Program
    {
        static void Main(string[] args)
        {
             int numMult, inicioInterv, fimInterval, resultado;

             Console.WriteLine("Informe um numero para ser o multiplicador");
             numMult = int.Parse(Console.ReadLine());

             /* if(numMult < 0)
              {
                  Console.WriteLine("O numero multiplicador não pode ser negativo nem maior que 300");
              }
              else
              {
                  Console.WriteLine("informe um numero positivo");
              }*/

             Console.WriteLine("Informe um numero para ser inicio do intervalo");
             inicioInterv = int.Parse(Console.ReadLine());

             Console.WriteLine("Informe um numero para ser o fim do intervalo");
             fimInterval = int.Parse(Console.ReadLine());

             

             for(int numintervalo = inicioInterv; numintervalo <= fimInterval; numintervalo++)
             {
                resultado = numMult * numintervalo;
             

                Console.WriteLine("Multiplicando: " + numMult);
                Console.WriteLine("Numero de inicio do intervalo: " + inicioInterv);
                Console.WriteLine("Numero de fim do inervalo: " + fimInterval);
                Console.WriteLine("-----------");
                Console.WriteLine(numMult + " x " + numintervalo + " = " + resultado);
             }
             


        }
    }
}
