using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti un program care stocheaza intr-un vector 3 variabile de tip double declarate de voi si le afiseaza parcurgand vectorul.

            double[] arr;

            arr = new double[3];

            arr[0] = 1.5;
            arr[1] = 2.8;
            arr[2] = 3.7;

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("Element at index " + i + " : " + arr[i]);

        }
    }
}
