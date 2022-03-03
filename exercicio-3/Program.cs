﻿using System;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a distancia percorrida em km:");
            decimal.TryParse(Console.ReadLine(), out decimal kmPercorrido);

            Console.WriteLine("Informe o combustivel gasto na viagem em litros:");
            decimal.TryParse(Console.ReadLine(), out decimal litrosGastos);

            Console.WriteLine($"Sua mádia foi de {kmPercorrido / litrosGastos}");
            Console.ReadLine();
        }
    }
}
