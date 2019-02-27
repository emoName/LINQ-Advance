using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Advance
{

    public delegate void MyDelegate(int a);
    class Clousure
    {

        MyDelegate[] _myDelegate = new MyDelegate[2];



        private void ClosureMethod()
        {

            int outside = 0;


            for ( int i = 0; i < 2; i++ )
            {
                int inside = 0;

                _myDelegate[i] = (int b) =>
                                            {
                                                outside++;
                                                inside++;
                                                Console.WriteLine("Call var -> " + b + " Outside : " + outside + " -> Inside : " + inside);
                                            };


            }


        }

        public void RunClosures()
        {
            //this.ClosureMethod();
            MyClass1 m = new MyClass1();
            MyClass2 n = new MyClass2();
            m.Mrthod1(_myDelegate);
            n.Mrthod1(_myDelegate);

            _myDelegate[0](3);
            _myDelegate[0](7);
            _myDelegate[0](3);
            _myDelegate[1](4);
            _myDelegate[1](4);
            _myDelegate[1](4);
            _myDelegate[1](4);
        }

    }

    class MyClass1
    {
        public void Mrthod1(MyDelegate[] m)
        {
            int outside = 0;

            m[0] = (int b) =>
            {
              int inside =1;
                outside++;
                inside++;
                Console.WriteLine("Call from Class 1 var -> " + b + " Outside : " + outside + " -> Inside : " + inside);
            };

        }
    }

    class MyClass2
    {
        public void Mrthod1(MyDelegate[] m)
        {
            int outside = 0;

            m[1] = (int b) =>
            {
                int inside = 1;
                outside++;
                inside++;
                Console.WriteLine("Call from Class 2 var -> " + b + " Outside : " + outside + " -> Inside : " + inside);
            };

        }
    }

}
