using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Bool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 9 - Escopo: \r\n");

            int idadeAna = 16;
            int idadeMaria = 18;
            bool acompanhado = true;
            string mensagemAdicional;

            Console.WriteLine("____________________________________________________ \r\n");

            Console.WriteLine("* Testando bool como true: \r\n");

            if (acompanhado == true)
            {
                Console.WriteLine("A idade da Ana é " + idadeAna + " anos.");
                mensagemAdicional = "Ela está acompanhada.";
                Console.WriteLine(mensagemAdicional);
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("A idade da Ana é " + idadeAna + " anos.");
                mensagemAdicional = "Ela NÃO está acompanhada.";
                Console.WriteLine(mensagemAdicional);
                Console.WriteLine("Não pode entrar!");
            }

            Console.WriteLine("\r\n____________________________________________________ \r\n");

            //Outra forma de fazer

            Console.WriteLine("* Testando bool como true e idade maior que 18: \r\n");

            if (idadeMaria >= 18 || acompanhado == true)
            {
                Console.WriteLine("A idade da Maria é " + idadeMaria + " anos.");
                mensagemAdicional = "Maria está acompanhada.";
                Console.WriteLine(mensagemAdicional);
                Console.WriteLine("Pode entrar!");
            }
            else
            {
                Console.WriteLine("A idade da Maria é " + idadeMaria + " anos.");
                mensagemAdicional = "Ela NÃO está acompanhada.";
                Console.WriteLine(mensagemAdicional);
                Console.WriteLine("Não pode entrar!");
            }
            Console.ReadLine();
        }
    }
}