using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace HotReloadDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Please press Enter:");
                Console.ReadKey();

                string code =
                    File.ReadAllText(
                        @"C:\Users\hassan\source\repos\HotReloadSimplified\HotReloadDemo\DynamicCode.txt");

                await CSharpScript.RunAsync(code);
            }
        }
    }
}
