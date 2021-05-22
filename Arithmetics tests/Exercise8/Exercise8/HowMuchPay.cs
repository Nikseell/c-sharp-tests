using System;

namespace Exercise8
{
    public class HowMuchPay
    {
        static double minimumWage = 8;
        static double maxHours = 60;

        public double SalaryCalc(double basePay, double hoursWorked)
        {
            double totalSalary = 0;

            if ((basePay < minimumWage || basePay <= 0))
            {
                return 0;
            }
            else if ((hoursWorked > maxHours || hoursWorked <= 0))
            {
                return 0;
            }
            else if (hoursWorked > 40)
            {
                totalSalary = basePay * 40 + 1.5 * basePay * (hoursWorked - 40);
            }
            else
            {
                totalSalary = basePay * hoursWorked;
            }

            return totalSalary;
        }
    }
}

