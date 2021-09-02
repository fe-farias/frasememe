using System;

namespace frasememe
{
    class Program
    {
        static void Main(string[] args)
        {
            string frasedigitada, frasememetonervoso;
            Console.WriteLine("O que você acha de mim? ");
            frasedigitada = Console.ReadLine();

            frasememetonervoso = $"{frasedigitada.Remove(10)}... NÃO NÃO, PERA. TÔ NERVOSO";

            Console.WriteLine(frasememetonervoso);

        }
    }
}
