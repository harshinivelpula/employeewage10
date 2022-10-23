using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewageday10
{
    internal class uc14
    {
        interface InEmployeeWageOops
        {
            public void addCompanyEmpWage(String company, int empRatePerHr, int numberOfWorkingDays, int maxHrPerMonth);
            public void computeEmpWage();

        }


        class CompanyEmpWage
        {
            public String company;
	        public int empRatePerHr;
            public int numberOfWorkingDays;
            public int maxHrPerMonth;
            public int totalEmpWage;
            ArrayList<Integer> dailyWage = new ArrayList<Integer>();
            public CompanyEmpWage(String company, int empRatePerHr, int numberOfWorkingDays, int maxHrPerMonth)
            {
                this.company = company;
                this.empRatePerHr = empRatePerHr;
                this.numberOfWorkingDays = numberOfWorkingDays;
                this.maxHrPerMonth = maxHrPerMonth;

            }
            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }
            public String toString()
            {
                return "Total employee wage for: " + company + " is " + totalEmpWage;
            }
        }

        class EmpWage
        {
            internal void computeEmpWage()
            {
                throw new NotImplementedException();
            }

            internal void addCompanyEmpWage(string v1, int v2, int v3, int v4)
            {
                throw new NotImplementedException();
            }

            internal string getTotalEmpWage(string v)
            {
                throw new NotImplementedException();
            }
        }

        private implements InEmployeeWageOops
        {
        const int IS_FULL_TIME = 1;
        const int IS_PART_TIME = 2;
        int daySalary;
        private int numOfCompany = 0;
        ArrayList<Integer> dailyWage = new ArrayList<Integer>();
        private ArrayList<CompanyEmpWage> companyEmpWageArrayList;
        private HashMap<String, CompanyEmpWage> companyEmpWageMap;
        public CompanyEmpWage()
        {
            companyEmpWageArrayList = new ArrayList<>();
            companyEmpWageMap = new HashMap<>();
        }
        public void DailyWage()
        {
            dailyWage.add(daySalary);
        }
        public void addCompanyEmpWage(String company, int empRatePerHr, int numberOfWorkingDays, int maxHrPerMonth)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(company, empRatePerHr, numberOfWorkingDays, maxHrPerMonth);
            companyEmpWageArrayList.add(companyEmpWage);
            companyEmpWageMap.put(company, companyEmpWage);

        }
        public void computeEmpWage()
        {
            for (int i = 0; i < companyEmpWageArrayList.size(); i++)
            {
                CompanyEmpWage companyEmpWage = companyEmpWageArrayList.get(i);
                companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage);
            }
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHrPerMonth && totalWorkingDays < companyEmpWage.numberOfWorkingDays)
            {

                totalWorkingDays++;
                double empCheck = Math.Floor(Math.random() * 10) % 3;
                switch ((int)empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                int daySalary = empHrs * companyEmpWage.empRatePerHr;
                companyEmpWage.dailyWage.add(daySalary);
                totalEmpHrs += empHrs;
                Console.WriteLine("totalWorkingDays: " + totalWorkingDays + "/ daly empHrs: " + empHrs + "/ totalEmpHrs: " + totalEmpHrs);
            }
            Console.WriteLine(companyEmpWage.dailyWage);
            return totalEmpHrs * companyEmpWage.empRatePerHr;


        }
         
        public int getTotalEmpWage(String company)
        {
            return companyEmpWageMap.get(company).totalEmpWage;
        }
        public static void main(String[] args)
        {
            EmpWage empWageBuilder = new EmpWage();
            empWageBuilder.addCompanyEmpWage("icici", 50, 2, 100);
            empWageBuilder.addCompanyEmpWage("DMart", 20, 4, 100);
            empWageBuilder.addCompanyEmpWage("accenture", 20, 6, 100);
            empWageBuilder.addCompanyEmpWage("IBM", 100, 8, 100);
            empWageBuilder.addCompanyEmpWage("google", 100, 10, 100);
            empWageBuilder.computeEmpWage();
            Console.WriteLine("Total wage of queried company: " + empWageBuilder.getTotalEmpWage("accenture"));
        }
    }

    internal class HashMap<T1, T2>
    {
    }

    internal class implements
    {
    }
}
