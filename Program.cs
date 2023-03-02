using System;
using CSharpObterCaracteresString.src;

namespace CSharpObterCaracteresString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Obter Caracteres String - Exemplo A **********");

            ExemploA caractereA = new ExemploA();

            Console.WriteLine(caractereA.AlfabetoA.Substring(0, 3));
            Console.WriteLine();

            Console.WriteLine("********** Obter Caracteres String - Exemplo B **********");
            
            ExemploB caractereB = new ExemploB();
            var myAlfabeto = caractereB.MyAlfabeto = "ABCDEFGHIJ";

            Console.WriteLine(myAlfabeto.Substring(0, 4));
            Console.WriteLine();

            Console.WriteLine("********** Obter Caracteres String - Exemplo C **********");
            
            var caractereC = ExemploC.AlfabetoC = "ABCDEFGHIJ";

            Console.WriteLine(caractereC.Substring(0, 5));
            Console.WriteLine();
        }
    }
}
