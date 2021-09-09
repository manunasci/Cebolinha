using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá meu nome é Cebolinha!");
            Console.WriteLine("Digite seu texto pala eu lel:");

            string textoDigitado = Console.ReadLine();
            Console.WriteLine(textoDigitado.Replace("R","L").Replace("r","l"));
        }
    }
}
