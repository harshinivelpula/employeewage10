using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewageday10
{
    internal class uc11
      
    {
        private readonly int totalempwage;

        public class empwagebuildarray : uc11
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;
            private readonly object uc11;
            private int numofcompany = 0;

            public int[] a = new int[5];
            private uc11[] companyempwagearray;

            public empwagebuildarray()
            {
                this.companyempwagearray = new uc11[5];
            }
            public void addcompanyempwage(string company, int emprateperhour, int numofworkingdays, int maxhourspermonth)
            {
                companyempwagearray[this.numofcompany] = new uc11(company, emprateperhour, numofworkingdays, maxhourspermonth);
                numofcompany++;
            }

            public void computeempwage()
            {
                for (int i = 0; i < numofcompany; i++)
                {
                    int totalempwage = this.computeempwage(uc11[i]);
                    Console.WriteLine(this.companyempwagearray[i].ToString());
                }
            }

            private int computeempwage(uc11 companyempwage)
            {
                return 0;
            }
            public int gettotalwage(int company)
            {
                return this.companyempwagearray[company].totalempwage;
            }
        }
    }
}
