using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simple_Event
{
    delegate void MyEventHandler();
    class MyEvent
    {
        public event MyEventHandler SomeEvent;

        public void OnSomeEvent()
        {
            if (SomeEvent != null)
                SomeEvent();
        }
    }
    class Program
    {
        static void handler()
        {
            Console.WriteLine("Event Occurred");
        }
        static void Main(string[] args)
        {
            MyEvent evt = new MyEvent();

            evt.SomeEvent += handler;

            evt.OnSomeEvent();
        }
    }
}
