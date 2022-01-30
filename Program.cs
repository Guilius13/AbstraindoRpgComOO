using System;
using dotnet_poo.src.Entities;
using static System.Console;

namespace dotnet_poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            WriteLine(arus.Attack());
            WriteLine(wizard.Attack(10));
            WriteLine(wizard.Attack(1));
        }
    }
}
