using System;

namespace DragRace
{
    public class Bmw : ICar
    {
        private int currentSpeed = 0;

        public int SpeedUp()
        {
            return currentSpeed += 15;
        }

        public int SlowDown()
        {
            return currentSpeed -= 15;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string ShowCarName()
        {
            return "Bmw";
        }

        public string StartEngine()
        {
            return "Rrrrrrr.....";
        }
    }
}