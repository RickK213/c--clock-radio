using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadioDemo
{
    class ClockRadio
    {
        string time = "4:20PM";
        bool isAlarmSet;
        string currentRadioStation;

        public void SetAlarm()
        {
            isAlarmSet = true;
        }
        public void ChangeRadioStation(string newStation)
        {
            currentRadioStation = newStation;
        }
    }
}
