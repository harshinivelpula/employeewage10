using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewageday10
{
    internal class totalworkinghrs
    {
        public static void conditions()
        {
            const int PART_TIME_HR = 8;
            const int DAILY_WAGE = 20, DAILY_HR = 8;
            Random random = new Random();
            int isemppr = random.Next(0, 2);
            if (isemppr == 1)
            {
                Console.WriteLine("present");
                Console.WriteLine(DAILY_WAGE * DAILY_HR);
                Console.WriteLine("Enter 1 - Part time & 2 - for full time employee");
                int choice = Convert.ToInt16(Console.ReadLine());
                int day_hr = 0;
                switch (choice)
                {
                    case 1:
                        day_hr = 4;
                        break;
                    case 2:
                        day_hr = 8;
                        break;
                    default:
                        day_hr = 0;
                        break;
                }
                if (day_hr == 0)
                {
                    Console.WriteLine("Wrong input");
                }
                else
                {
                    {
                        int WaPhr = 20;
                        int day_month = 0;
                        int totHrs = 0;
                        int tot_wag = 0;
                        while (day_month <= 20 && totHrs <= 100)
                        {
                            totHrs = totHrs + day_hr;
                            day_month = day_month + 1;
                            if (day_month == 21)
                            {
                                break;
                            }
                            Console.WriteLine("Wage = " + (WaPhr * day_hr) + " for day " + (day_month));
                        }
                        tot_wag = (day_month - 1) * WaPhr * day_hr;
                        Console.WriteLine("Total wage of the employee is = " + tot_wag);
                    }
                }
            }
            else
            {
                Console.WriteLine("absent");
            }
            Console.WriteLine("workinghours");

        }
    }
}
