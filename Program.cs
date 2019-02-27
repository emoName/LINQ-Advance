using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Advance
{
    class Program
    {
        static void Main(string[] args)
        {

            StandartQueryOperators queryOperators = new StandartQueryOperators();

            queryOperators.FiltringMethod();
            queryOperators.ProjectionMethod();


            Clousure clousure = new Clousure();

            clousure.RunClosures();



            Console.ReadLine();
        }
    }
}
