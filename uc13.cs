using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeewageday10
{
    internal class uc13
    {
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
			const int IS_FULL_TIME = 1;
			const int IS_PART_TIME = 2;
			int daySalary;
			private int numOfCompany = 0;
			ArrayList<Integer> dailyWage = new ArrayList<Integer>();
			private ArrayList<CompanyEmpWage> companyEmpWageArrayList;
			public EmpWage()
			{
				companyEmpWageArrayList = new ArrayList<>();
			}
			public void DailyWage()
			{
				dailyWage.add(daySalary);
			}
			private void addCompanyEmpWage(String company, int empRatePerHr, int numberOfWorkingDays, int maxHrPerMonth)
			{
				CompanyEmpWage uc13 = new CompanyEmpWage(company, empRatePerHr, numberOfWorkingDays, maxHrPerMonth);
				companyEmpWageArrayList.add(uc13);


			}
			private void computeEmpWage()
			{
				for (int i = 0; i < companyEmpWageArrayList.size(); i++)
				{
					CompanyEmpWage companyEmpWage = companyEmpWageArrayList.get(i);
					companyEmpWage.setTotalEmpWage(this.computeEmpWage(companyEmpWage));
					System.out.println(companyEmpWage);
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
					double empCheck = Math.floor(Math.random() * 10) % 3;
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

					}
					int daySalary = empHrs * companyEmpWage.empRatePerHr;
					companyEmpWage.dailyWage.add(daySalary);
					totalEmpHrs += empHrs;
					System.out.println("totalWorkingDays: " + totalWorkingDays + "/ daly empHrs: " + empHrs + "/ totalEmpHrs: " + totalEmpHrs);
				}
				System.out.println(companyEmpWage.dailyWage);
				return totalEmpHrs * companyEmpWage.empRatePerHr;


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
			}
		}
	}

    internal class Integer
    {
    }
}
