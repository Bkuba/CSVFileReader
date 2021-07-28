using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvFileReader.Models
{
    public class CSVFileModel
    {
        public int FirstId { get; set; }
        public int SecondId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Company { get; set; }
        public string City { get; set; }
        public string Position { get; set; }
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int ThirdNumber { get; set; }
    }
}
