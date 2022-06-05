using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    internal class Cars
    {
        public string Model { get; set; }
        public string Vendor { get; set; }
        public short Year { get; set; }
        public string Engine { get; set; }

        public override string ToString()
            => $"{Vendor} {Model}  {Year} Engine: {Engine}";
    }
}
