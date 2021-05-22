using System;

namespace Exercise7
{
    public class GravityCalculator
    {
        public double GravityCalculatorFormula(double x)
        {
            if (x <= 0)
            {
                return 0;
            }
            else
            {
                double gravity = -9.81;
                double initialVelocity = 0.0;
                double initialPosition = 0.0;
                double finalPosition = 0.0;

                finalPosition = (0.5 * (gravity) * (x * x) + initialPosition);

                return finalPosition;
            }
        }
    }
}
