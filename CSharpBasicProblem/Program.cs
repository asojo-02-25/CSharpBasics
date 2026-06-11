using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpBasics;

namespace CSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# basic syntax exercises");
            Console.WriteLine("Implement the methods in BasicSyntaxProblems.cs, then run: dotnet test");

            try
            {
                Console.WriteLine($"Add(2, 3) = {BasicSyntaxProblems.Add(2, 3)}");
            }
            catch (NotImplementedException)
            {
                Console.WriteLine("Methods are not implemented yet.");
            }

        }
    }
}
