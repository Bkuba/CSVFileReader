using CsvFileReader.Models;
using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration.Attributes;

namespace CsvFileReader.Services
{
    public class ReaderCSVService
    {
        public static void printChildren(List<CSVFileModel> allRecords, List<CSVFileModel> parents)
        {
            
            for (int i = 0; i < parents.Count(); i++)
            {
                var children = allRecords
                                    .Where(x => x.SecondId == parents[i].FirstId)
                                    .OrderBy(x => x.FirstId)
                                    .ToList();
                var parentsPrint = parents.ElementAt(i);

                Console.WriteLine($"{parentsPrint.Name}\t{parentsPrint.Surname}\t{parentsPrint.Company}\t{parentsPrint.City}\t{parentsPrint.Position}");
                children.ForEach(x => Console.WriteLine("-> " + $"{x.Name}\t{x.Surname}\t{x.Company}\t{x.City}\t{x.Position}"));

                int level = 0;
                do
                {
                    level++;
                    var children2 = allRecords
                        .Where(x => x.SecondId == children.LastOrDefault().FirstId)
                        .OrderBy(x => x.FirstId)
                        .ToList();
                    children = children2;

                    foreach (var child in children)
                    {
                        printWorker(level);
                        Console.WriteLine($"{child.Name}\t{child.Surname}\t{child.Company}\t{child.City}\t{child.Position}");
                    }
                } while (children.Count != 0);
            }
        }

        public static void printWorker(int level)
        {
            for (var i = 0; i < level; i++)
            {
                Console.Write("\t");
            }
            Console.Write("-> "); 
        }

    }
}
