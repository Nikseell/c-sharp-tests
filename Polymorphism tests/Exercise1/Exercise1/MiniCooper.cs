using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class MiniCooper: ICar, INitrous
    {
        private int currentSpeed = 0;

        public int SpeedUp()
        {
            return currentSpeed += 30;
        }

        public int SlowDown()
        {
            return currentSpeed -= 30;
        }

        public int UseNitrousOxideEngine()
        {
            return currentSpeed += 15;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string ShowCarName()
        {
            return "Mini Cooper";
        }

        public string StartEngine()
        {
            return "Rrr...";
        }
    }
}
