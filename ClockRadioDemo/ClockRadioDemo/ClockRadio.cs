using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadioDemo
{
    class ClockRadio
    {
        public string time = "1:16PM";
        public bool isAlarmSet;
        public string currentRadioStation;

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
