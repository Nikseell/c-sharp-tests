using System;
using System.Collections.Generic;
using System.Text;

namespace DragRace
{
    public interface ICar
    {
        int SpeedUp();

        int SlowDown();

        string ShowCurrentSpeed();

        string ShowCarName();

        string StartEngine();
    }
}
