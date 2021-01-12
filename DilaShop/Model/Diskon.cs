using System;
using System.Collections.Generic;
using System.Text;

namespace DilaShop.Model
{
    public class Diskon
    {
        public string diskon { get; set; }
        public double potongan { get; set; }

        public Diskon(string diskon, double potongan)
        {
            this.diskon = diskon;
            this.potongan = potongan;
        }
    }
}
