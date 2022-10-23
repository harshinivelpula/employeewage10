using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewageday10
{
    internal class uc9
    {
        public class savetotalwage
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;

            private string company;
            private int emprateperhour;
            private int numofworkingdays;
            private int maxhourspermonth;
            private int totalempwage;
            public savetotalwage(string company, int emprateperhour, int numofworkingdays, int maxhourspermonth)
            {
                this.company = company;
                this.emprateperhour = emprateperhour;
                this.numofworkingdays = numofworkingdays;
                this.maxhourspermonth = maxhourspermonth;
            }
            public void empwage()
            {
                int emphrs = 0, totalemphrs = 0, totalworkingdays = 0;
                while (totalemphrs <= this.maxhourspermonth && totalworkingdays < this.numofworkingdays)
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
                    Console.WriteLine("days#:" + totalworkingdays + "emp hrs:" + emphrs);
                }
                totalempwage = totalemphrs * this.emprateperhour;
                Console.WriteLine("total emp wage for company:" + company + "is:" + totalempwage);
            }
            public string tostring()
            {
                return "totalempwage emp wage for company:" + this.company + "is:" + this.totalempwage;
            }
        }
    }
}
