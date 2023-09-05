using System;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq.Expressions;

namespace HW9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string filePath = @"Z:\Desktop\Symonenko.txt";
                string[] lines = File.ReadAllLines(filePath);

                lines = lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

                if (lines.Any())
                {
                    Console.WriteLine("The number of symbols in every line: ");

                    var countOfSymbols = lines.Select(line => line.Length);

                    for (int i = 0; i < lines.Length; i++)
                    {
                        Console.WriteLine($"Line {i + 1} has {countOfSymbols.ElementAt(i)}");
                    }

                    var longestLine = lines.OrderByDescending(line => line.Length).First();
                    Console.WriteLine($"The longest line is: {longestLine}");

                    var shortestLine = lines.OrderBy(line => line.Length).First();
                    Console.WriteLine($"The shortest line is: {shortestLine}");

                    var linesVar = lines.Where(line => line.Contains("var"));
                    Console.WriteLine("Lines containing the word var:");
                    if (linesVar.Any())
                    {
                        foreach (string line in linesVar)
                        {
                            Console.WriteLine(line);
                        }
                    }
                    else
                    {
                        throw new ApplicationException("Sorry. I cannot find \"var\"!");
                    }

                    var varCount = lines.Sum(line => line.Split(' ').Count(word => word == "var"));
                    Console.WriteLine($"Number of \"var\": {varCount}");
                }
                else
                {
                    throw new ApplicationException("The file is empty!");
                }
            }
            catch (ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
        }
    }
}

