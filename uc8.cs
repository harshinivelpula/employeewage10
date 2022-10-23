using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewageday10
{
    internal class uc8
    {
        public class multiplecompany
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;
            public static int multipleempwage(string company, int emprateperhour, int numofworkingdays, int maxhourspermonth)
            {
                int emphrs = 0, totalemphrs = 0, totalworkingdays = 0;
                while (totalemphrs <= maxhourspermonth && totalworkingdays < numofworkingdays)
                {
                    totalworkingdays++;
                    Random random = new Random();
                    int empcheck = random.Next(0, 3);
                    switch (empcheck)
                    {
                        case IS_PART_TIME:
                            emphrs = 4;
                            break;
                        case IS_FULL_TIME:
                            emphrs = 8;
                            break;
                        default:
                            emphrs = 0;
                            break;

                    }
                    totalemphrs += emphrs;
                    Console.WriteLine("day#:" + totalworkingdays + "emp hrs:" + emphrs);
                }
                int totalempwage = totalemphrs * emprateperhour;
                Console.WriteLine("total emp wage for company:" + company + "is:" + totalempwage);
                return totalempwage;
            }
            public static void main(string[] args)
            {
                multipleempwage("dmart", 20, 2, 10);
                multipleempwage("reliance", 10, 4, 20);
            }
        }
    }
}
