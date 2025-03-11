using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022330128
{
    internal class FanLaptop
    {
        public enum laptopState
        {
            Quiet, Balanced, Performance, Turbo
        }

        public laptopState state = laptopState.Quiet;

        public void modeUpCoba()
        {
            state = laptopState.Turbo;
        }

        public void modeDownCoba()
        {
            state = laptopState.Quiet;
        }

        public void modeUp()
        {
            if ((int)state < (int)laptopState.Turbo) state++ ;
            Console.WriteLine($"Fan {state - 1} telah berubah menjadi  Fan{state}");
        }

        public void modeDown()
        {
            if ((int)state > (int)laptopState.Quiet) state--;
        }

        public void turboShortcut()
        {
            laptopState stateAwal = state;
            if (state == laptopState.Quiet)
            {
                state = laptopState.Turbo;
            }
            else if (state == laptopState.Turbo)
            {
                state = laptopState.Quiet;
            }
            Console.WriteLine($"Fan {stateAwal} telah berubah menjadi  Fan{state}");
        }
    }
}
