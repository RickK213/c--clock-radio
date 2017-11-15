using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadioDemo
{
    class RunClockRadio
    {
        public void Start()
        {
            ClockRadio myClockRadio = new ClockRadio();
            Console.WriteLine("Original clock radio time:");
            Console.WriteLine(myClockRadio.time);
            Console.WriteLine("\nEnter new time");
            myClockRadio.time = Console.ReadLine();
            Console.WriteLine("\nYour clock has been set to:");
            Console.WriteLine(myClockRadio.time);
            myClockRadio.currentRadioStation = "102.1 Today's Alternative";
            Console.WriteLine("\nOriginal clock radio station:");
            Console.WriteLine(myClockRadio.currentRadioStation);
            Console.WriteLine("\nEnter new radio station");
            myClockRadio.currentRadioStation = Console.ReadLine();
            Console.WriteLine("\nYour radio station has been set to:");
            Console.WriteLine(myClockRadio.currentRadioStation);
            Console.WriteLine("\nIs your alarm originally set to 'on'?");
            Console.WriteLine(myClockRadio.isAlarmSet);
            Console.WriteLine("\nEnter 'yes' to set your alarm");
            string userAlarmChoice = Console.ReadLine();
            if (userAlarmChoice == "yes")
            {
                myClockRadio.isAlarmSet = true;
            }
            Console.WriteLine("The 'on' state of your alarm is currently set to:");
            Console.WriteLine(myClockRadio.isAlarmSet);
        }
    }
}
