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
            this.ClosureMethod();
            _myDelegate[0](3);
            _myDelegate[0](7);
            _myDelegate[0](3);
            _myDelegate[1](4);
            _myDelegate[1](4);
            _myDelegate[1](4);
            _myDelegate[1](4);
        }






    }
}
