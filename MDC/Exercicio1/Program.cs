using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            var A = 0;
            var B = 0;

            Console.WriteLine("Informe o valor A:");
            int.TryParse(Console.ReadLine(), out A);
            Console.WriteLine("Informe o valor B:");
            int.TryParse(Console.ReadLine(), out B);

            Console.WriteLine(String.Format("{0} + {1} = {2}", A, B, A + B));
            Console.WriteLine(String.Format("{0} - {1} = {2}", A, B, A - B));
            if (B == 0)
                Console.WriteLine("{0} / {1} = {2}", A, B, "Não pode ser dividido por 0");
            else
                Console.WriteLine(String.Format("{0} / {1} = {2}", A, B, A / B));
            Console.WriteLine(String.Format("{0} * {1} = {2}", A, B, A * B));
            Console.WriteLine(String.Format("{0} é {1}", A, RetornarParImpar(A)));
            Console.WriteLine(String.Format("{0} é {1}", B, RetornarParImpar(B)));
        }

        private static string RetornarParImpar(int num)
        {
            if (num % 2 == 0)
                return "Par";
            else
                return "Ímpar";
        }
    }
}
