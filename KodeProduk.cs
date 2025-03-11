using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022330128
{
    internal class KodeProduk
    {
        public enum produkElektronik
        {
            Laptop, Smartphone, Tablet, Headset, Keyboard, Mouse, Printer, Monitor, Smartwatch, Kamera

        };
        public string[] kodeProduk =
        {
            "E100", "E101", "E102", "E103", "E104", "E105", "E106", "E107", "E108", "E109"
        };

        public  string getKodeProduk(produkElektronik i)
        {
            return kodeProduk[(int) i];
        }
    }
}
