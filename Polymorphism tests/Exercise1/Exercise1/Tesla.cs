using System;

namespace DragRace
{
    public class Tesla : ICar
    {
        private int currentSpeed = 0;

        public int SpeedUp() {
            return currentSpeed += 20;
        }

        public int SlowDown() {
            return currentSpeed -= 20;
        }

        public string ShowCurrentSpeed() {
            return currentSpeed.ToString();
        }

        public string ShowCarName()
        {
            return "Tesla";
        }

        public string StartEngine() {
            return "-- silence ---";
        }
    }
}