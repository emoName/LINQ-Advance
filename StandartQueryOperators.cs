using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Advance
{
    class StandartQueryOperators
    {

        public void StringMethod()
        {
            string s = "asdfghjk";

            IEnumerator en = s.GetEnumerator();

            while ( en.MoveNext() )
            {

                Console.WriteLine(en.Current);
            }
            en.Reset();
        }

        public void FiltringMethod()
        {
            var list = new List<int>() { 2, 5, 3, 6, 1, 6, 98, 945, 8 };

            // metodele functioneaza cu { i-1   }
            // daca iese din Out of rande  Take si Skip nu dau eroae
            var f1 = list.SkipWhile(i => i < 3).Skip(2).TakeWhile(i => i < 100).Take(5).Where(i => i >= 3).Distinct();
            //  Operatia afiseza tipul de date 
            //Console.WriteLine(  f1.ToString());

            foreach ( var item in f1 )
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();

        }

        struct MyStruct
        {
            public int a;
            public string s;
        }

        public void ProjectionMethod()
        {

            var list = new[] { 1, 3, 4, 5, 6, 4, 6, 6333, 544, 22, 0, 334, 003, 1 };

            var f1 = list.Select(i => i).Distinct();


            foreach ( var item in f1 )
            {
                Console.Write(item + " ");
            }

            var list2 = new List<MyStruct>() { new MyStruct() {a=2,s="s222rdfg" },
                                               new MyStruct() {a=3,s="s333rdfg" },
                                               new MyStruct() {a=1,s="s111rdfg" },
                                               new MyStruct() {a=6,s="s666rdfg" },
                                               new MyStruct() {a=9,s="s999rdfg" }
                                                };



            var f2 = list2.Where(i => i.a > 2).SelectMany(i => i);





        }



    }
}
