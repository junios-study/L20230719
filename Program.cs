using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace L20230719
{
    class Fule
    { }
    class Gasolin : Fule
    {

    }
    class Dissel : Fule
    {

    }
    class Car
    {
        public void SetFule(Fule gasolin) 
        {
            //if 가솔린 넣는다.
        }
        public Fule GetFule() { return new Fule(); }

        private Fule fule;
    }

    class TV
    {
        public TV()
        {
            _tr = 10;
        }
        public void On() { }
        public void Off() { }

        private void Tune() 
        {
            Console.WriteLine("튠한다.");
        }

        //C++
        //public void SetLCD() {}
        //public int GetLCD() { return LCD; }
        //public void SetDiode() { }
        //public int GetDiode() { return Diode; }
        //public void SetTR() { }
        //public int GetTR() { return TR; }

        public int lcd {  get; }

        public int tr { get; set; }

    }

    class Engine
    {
        public void Run() 
        {
            while(true)
            {
                Input();
                Update();
                Render();
            }
        }

        private void Update()
        {

        }
        private void Render() 
        {
        }

        private void Input()
        {

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            TV tv = new TV();
            tv.tr = 1;
            Console.WriteLine(tv.tr);

        }
    }
}
