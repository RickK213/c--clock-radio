using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadioDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            RunClockRadio myRunClockRadio = new ClockRadioDemo.RunClockRadio();
            myRunClockRadio.Start();
            Console.ReadKey();
        }
    }
}
