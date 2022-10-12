using System;
using Lab_1_POO;
/*
Laboratorio 1 de PA
*/
namespace Programa_1_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto vocho1 = new Auto();
            vocho1.color = "Azul";
            vocho1.modelo = 2000;
            vocho1.marca = "Vocho";
            Console.WriteLine(vocho1.color);
            Console.WriteLine(vocho1.modelo);
            Console.WriteLine(vocho1.marca);
            vocho1.enciende();
            vocho1.acelera();
            vocho1.frena();

            Auto chevy = new Auto();
            chevy.color = "azul";
            chevy.modelo = 2010;
            chevy.marca = "Chevrolet";
            Console.WriteLine(chevy.color);
            Console.WriteLine(chevy.modelo);
            Console.WriteLine(chevy.marca);
            chevy.enciende();
            chevy.acelera();
            chevy.frena();
            Console.Read();
        }
    }
}