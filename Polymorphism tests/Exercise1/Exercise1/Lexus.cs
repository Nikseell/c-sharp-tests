using System;

namespace DragRace
{
    public class Lexus : ICar, INitrous
    {
        private int currentSpeed = 0;

        public int SpeedUp()
        {
            return currentSpeed += 17;
        }

        public int SlowDown()
        {
            return currentSpeed -= 17;
        }

        public string ShowCurrentSpeed()
        {
            return currentSpeed.ToString();
        }

        public string ShowCarName()
        {
            return "Lexus";
        }

        public int UseNitrousOxideEngine()
        {
            return currentSpeed += 20;
        }

        public string StartEngine()
        {
            return "Rrrrrrr.....";
        }
    }
}