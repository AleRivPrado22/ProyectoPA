using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_POO
{   
    public class Auto
    {
        public string color = "";
        public int modelo = 0;
        public string marca = "";
        public void enciende()
        {
            Console.WriteLine("Se encendio el auto.");
        }
        public void acelera()
        {
            Console.WriteLine("El auto esta acelerando.");
        }
        public void frena()
        {
            Console.WriteLine("El auto ha frenado.");
        }
    }
}
