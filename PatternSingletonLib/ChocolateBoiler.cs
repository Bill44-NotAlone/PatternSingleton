using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSingletonLib
{
    public class ChocolateBoiler
    {
        private bool empty;
        private bool boiled;
        public static int counter = 0;
        private static ChocolateBoiler uniqueInstance = null;

        private ChocolateBoiler()
        {
            counter = counter + 1;
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetChocolateBoiler()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new ChocolateBoiler();
            }
            return uniqueInstance;
        }

        public void Fill()
        {
            if (empty)
            {
                empty = false;
                boiled = false;
            }
        }

        public void Drain()
        {
            if(boiled & !empty) empty = true;
        }

        public void Boil()
        {
            if (!empty & !boiled) boiled = true;
        }
    }
}
