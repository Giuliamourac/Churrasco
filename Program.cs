using System;

namespace Churrasco
{
    class Program
    {
        static void Main(string[] args)
        {
            int crianca, adultoA, adulto, adultos, pessoas;
            double carne, acompanhamento, cerveja, refri, agua;

            Console.WriteLine($"Vamos calcular a quantidade de alimento e bebidas necessarias para um churrasco.");

            Console.WriteLine($"Digite a quantidade de criancas.");
            crianca = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine($"Digite a quantidade de adultos que consomem alcool.");
            adultoA = Convert.ToInt32(Console.ReadLine()!);

            Console.WriteLine($"Digite a quantidade de adultos que nao consomem alcool.");
            adulto = Convert.ToInt32(Console.ReadLine()!);

            adultos = adulto + adultoA;

            pessoas = adultos + crianca;

            carne = ((0.4 * adultos) + (0.2 * crianca));

            acompanhamento = (0.2 * pessoas);

            cerveja = (2 * adultoA);

            refri = ((crianca + adulto) * 0.5);

            agua = (pessoas * 0.4);

            Console.WriteLine("--- Churrasco ---");
            Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......: {adultoA}");
            Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...: {adulto}");
            Console.WriteLine($"Crianças........................................: {crianca} \n");
            Console.WriteLine($"Carne.............: {carne:F1}Kg");
            Console.WriteLine($"Acompanhamentos...: {acompanhamento:F1}Kg");
            Console.WriteLine($"Cerveja...........: {cerveja:F1}L");
            Console.WriteLine($"Refrigerante......: {refri:F1}L");
            Console.WriteLine($"Água..............: {agua:F1}L");
        }
    }
}