using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeploobLibrary1
{
    public class TeploobmenOutputData
    {
        public double m { get; set; }
        public double y0 { get; set; }
        public double Proizv { get; set; }
        public List<TeploobmenOutputRow> Rows { get; set; }
        public List<TeploobmenOutputRow> Rows1 { get; set; }
    }
}
