using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace L20230719
{
    /// <summary>
    /// ver 2.0
    /// </summary>
    class A
    {
        //accessor
        public A() { }
        ~A() { }

        public int key
        {  
            get
            {
                //초기값이 없으면 
                //파일에서 읽기
                return _key;
            }

            set
            {
                if (value >= 1111 && value <= 9999)
                {
                    //파일에 저장
                    _key = value;
                }
            }
        }

        private int _key;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();

            a.key = 1234;
            a.key = 1;
            Console.WriteLine(a.key);

        }
    }
}
