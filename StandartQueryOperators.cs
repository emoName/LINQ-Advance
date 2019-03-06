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
        struct MyStruct
        {

            public int a;
            public string s;
        }

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
            //                          -2          -5               3, 6, 1, 6, 98             6,6,98         6,98
            //  Operatia afiseza tipul de date 
            //Console.WriteLine(  f1.ToString());

            foreach ( var item in f1 )
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();

        }



        public void ProjectionMethod()
        {

            var list = new[] { 1, 3, 4, 5, 6, 4, 6, 6333, 544, 22, 0, 334, 003, 1 };

            var test = list.FirstOrDefault(x => x > 1000000);

            if ( test != null )
            {

            }

            var f1 = list.Select(i => i).Distinct();


            foreach ( var item in f1 )
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            var list2 = new List<MyStruct>() { new MyStruct() {a=2,s="s222rdfg" },
                                               new MyStruct() {a=3,s="s333rdfg" },
                                               new MyStruct() {a=1,s="s111rdfg" },
                                               new MyStruct() {a=6,s="s666rdfg" },
                                               new MyStruct() {a=1,s="s999rdfg" }
                                                };


            var f2 = list2.Where(i => i.a > 2).SelectMany(i => i.s);

            Console.WriteLine("====Join====");

            var f3 = list.Join(list2,
                                      l => l,// join condition
                                      l2 => l2.a,
                                      (l, l2) => new
                                      { // return values
                                          _id = l,
                                          _name = l2.s
                                      });

            list2.Add(new MyStruct() { a = 6333, s = "Interpretabil ----===----" });
            Console.WriteLine("Join ==============================================");
            foreach ( var item in f3 )
            {
                Console.WriteLine(item._id + " => " + item._name);
            }
            Console.WriteLine();
            // LeftJoin
            var f4 = list.GroupJoin(list2,
                                            l => l,
                                            l2 => l2.a,
                                            (a, collection) => new
                                            {
                                                _id = a,
                                                _name = collection.Select(s => s.s)

                                            })
                                            .OrderBy(x => x._id)
                                            .GroupBy(y => y._id)
                                            .Distinct();
            Console.WriteLine("Grup Join Left ==========================================");
            foreach ( var item in f4 )
            {

                // Console.WriteLine(item._id + " :");
                foreach ( var l in item )
                {
                    Console.WriteLine(l._id + " :");
                    foreach ( var t in l._name )
                    {

                        Console.WriteLine("\t" + t);
                    }
                }

            }


            var students = new List<string>() { "Vitalii" ,"Vasea" , "Vitalii", "Alex"};

            var test2 = students.Where(c =>
            {
                Console.WriteLine($"{c}");
                if ( c == "Vitalii" )
                    return true;
                else
                    return false;
            });


            var count2 = test2.Count(c =>
            {
                Console.WriteLine("-- I am in first-- ");
                return true;
            });







            GenerationMethod();

        }

        public void GenerationMethod()
        {
            var list = Enumerable.Repeat("abc ", 4);
            var list2 = Enumerable.Range(35, 100);

        }





    }
}
