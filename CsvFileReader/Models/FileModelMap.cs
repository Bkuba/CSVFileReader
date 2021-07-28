using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvFileReader.Models
{
    public class FileModelMap : ClassMap<CSVFileModel>
    {
        public FileModelMap()
        {
            Map(m => m.FirstId).Index(0);
            Map(m => m.SecondId).Index(1);
            Map(m => m.Name).Index(2);
            Map(m => m.Surname).Index(3);
            Map(m => m.Company).Index(4);
            Map(m => m.City).Index(5);
            Map(m => m.Position).Index(6);
            Map(m => m.FirstNumber).Index(7);
            Map(m => m.SecondNumber).Index(8);
            Map(m => m.ThirdNumber).Index(9);
        }
    }
}
