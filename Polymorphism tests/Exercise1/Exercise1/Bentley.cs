using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public class Bentley : ICar
    {
        private int currentSpeed = 0;

        public int SpeedUp()
        {
            return currentSpeed += 13;
        }

        public int SlowDown()
        {
            return currentSpeed -= 13;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }
        public string ShowCarName()
        {
            return "Bentley";
        }

        public string StartEngine()
        {
            return "Brumm...";
        }
    }
}
