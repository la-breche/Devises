using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace LuccaDevises.Services
{
    public class InputChecker
    {
        public static bool CheckArgs(string[] args)
        {
            return args.Length == 1
                && File.Exists(args[0]);
        }

        public static bool CheckFile(List<string> lines)
        {
            if (lines.Count() <= 3)
            {
                return false;
            }

            var firstLine = lines.First().Replace(" ", "");
            var secondLine = lines.Skip(1).First().Replace(" ", "");
            var othersLines = lines.Skip(2).Select(l=> l.Replace(" ", "")).ToList();

            return CheckFirstLine(firstLine) && CheckSecondLine(secondLine) && CheckOthers(secondLine, othersLines);
        }

        public static bool CheckFirstLine(string line)
        {
            var splited = line.Split(';');

            return splited.Count() == 3 && CheckDevises(splited[0]) && CheckInteger(splited[1]) && CheckDevises(splited[2]);
        }

        public static bool CheckSecondLine(string line)
        {
            return CheckInteger(line);
        }

        public static bool CheckOthers(string secondLine, List<string> others)
        {
            int otherCounter = int.Parse(secondLine);
            if (otherCounter != others.Count())
            {
                Console.WriteLine("The number of exchange rates provided is not respected");
            }

            foreach (string line in others)
            {
                if (!CheckOther(line))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool CheckDevises(string devise)
        {
            return !string.IsNullOrEmpty(devise) && devise.Length == 3;
        }

        public static bool CheckInteger(string integer)
        {
            try
            {
                int result;
                return !string.IsNullOrEmpty(integer) && int.TryParse(integer, out result);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool CheckOther(string line)
        {
            var splited = line.Split(';');

            return splited.Count() == 3 && CheckDevises(splited[0]) && CheckDevises(splited[1]) && CheckRate(splited[2]);
        }

        public static bool CheckRate(string rate)
        {
            try
            {
                return !string.IsNullOrEmpty(rate) && Regex.IsMatch(rate, @"^\d*\.?\d{0,4}$");
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
