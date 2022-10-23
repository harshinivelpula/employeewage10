using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewageday10
{
    internal class parttime
    {
        public static void isparttime()
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int emphrs = 0;
            int empwage = 0;
            Random random = new Random();
            int empcheck = random.Next(3);
            if (empcheck == IS_FULL_TIME)
            {
                Console.WriteLine("employee is full time");
                emphrs = 8;
            }
            else if (empcheck == IS_PART_TIME)
            {
                Console.WriteLine("employee is part time");
                emphrs = 4;
            }
            else
            {
                Console.WriteLine("employee is absent");
                emphrs = 0;
            }
            empwage = emphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("emp wage:" + empwage);
        }
    }
}
