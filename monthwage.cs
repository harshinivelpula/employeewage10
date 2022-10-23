using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewageday10
{
    internal class monthwage
    {
        public static void monthwages()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int WORKING_DAYS_PER_MONTH = 20;
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(3);
            switch (empcheck)
            {
                case IS_FULL_TIME:
                    Console.WriteLine("employee is full time");
                    emphrs = 8;
                    break;

                case IS_PART_TIME:
                    Console.WriteLine("employee is part time");
                    emphrs = 4;
                    break;
                default:
                    Console.WriteLine("employee is absent");
                    emphrs = 0;
                    break;
                    Console.WriteLine("Wages for month: ");
            }
            {
                long wages = 0;
                for (int i = 1; i <= 20; i++) ;


            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("emp wage:" + empwage);

        }
    }
}
