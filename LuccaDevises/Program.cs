using LuccaDevises.Services;
using System;
using System.IO;
using System.Linq;

namespace LuccaDevises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (InputChecker.CheckArgs(args))
            {
                var lines = File.ReadAllLines(args[0]);
                if (InputChecker.CheckFile(lines.ToList()))
                {
                    Converter converter = new Converter();
                    var result = converter.Convert(lines.ToList());

                    if (result == 0)
                    {
                        Console.WriteLine($"The conversion cannot be established from the conversion table provided.");
                    }
                    else
                    {
                        Console.WriteLine(result.ToString());
                    }
                }
                else
                {
                    Console.WriteLine($"The file format is not respected.");
                }
            }
            else
            {
                Console.WriteLine($"Only one argument needed, it must be an accessible file path.");
            }
        }


    }
}
