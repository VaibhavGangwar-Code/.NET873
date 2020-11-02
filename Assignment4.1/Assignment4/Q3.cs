using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    interface Icar
    {
        string Break();
        string Engine();

    }

    class Benz : Icar
    {
        public string Break()
        {
            return "auto break";
        }

        public string Engine()
        {
            return "OM654 engine";

        }

        internal void BenzFunctionality()
        {
            Console.WriteLine("Benz car has Pre-Safe Break and Distronic Plus Technology");
        }
    }

    class Toyota : Icar
    {
        public string Break()
        {
            return "pad disk break";
        }

        public string Engine()
        {
            return "dynamic force engine";
        }

        internal void ToyotaFunctionality()
        {
            Console.WriteLine("Toyota cars have electronic modulated suspension");
        }
    }


    class Cars
    {
        static void Main()
        {
            Benz BENZ = new Benz();
            Console.WriteLine("Benz break : {0} and Benz Engine:{1}", BENZ.Break(), BENZ.Engine());
            BENZ.BenzFunctionality();

            Toyota TOYOTA = new Toyota();
            Console.WriteLine("\nToyota break : {0} and Toyota Engine:{1}", TOYOTA.Break(), TOYOTA.Engine());
            TOYOTA.ToyotaFunctionality();

            Console.Read();
        }
    }

}



