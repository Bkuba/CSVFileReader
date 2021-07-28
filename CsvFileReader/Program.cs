using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using CsvFileReader.Models;
using CsvFileReader.Services;

namespace CsvFileReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the file path:");
            string filePath = Console.ReadLine()
;
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            using (var streamReader = new StreamReader(@filePath))
            using (var csvReader = new CsvReader(streamReader, config))
            {
                csvReader.Context.RegisterClassMap<FileModelMap>();
                var records = csvReader.GetRecords<CSVFileModel>().ToList();

                var parents = records.Where(x => x.SecondId == 0).OrderBy(x => x.FirstId).ToList();

                ReaderCSVService.printChildren(records, parents);
            }
        Console.ReadLine();
        }
    }
}


