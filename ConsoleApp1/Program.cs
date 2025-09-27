using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> {"Darek", "Marzena", "Justyna"};

            Action<string> greet = name => Console.WriteLine($"Hello, {name}!");

            names.ForEach(greet);

            // Możesz przypisać istniejącą metodę do Action
            Action<string> logger = ShowMessage;

            logger("Aplikacja uruchomiona");

            // Action jako parametr metody
            ProcessUsers(new List<string> { "Darek", "Adam", "Łukasz" }, name => Console.WriteLine($"Witaj, {name}!"));

            Console.ReadKey();
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine($"[INFO] {message}");
        }

        static void ProcessUsers(List<string> users, Action<string> action)
        {
            foreach (var user in users) {
                action(user);
            }
        }
    }
}
