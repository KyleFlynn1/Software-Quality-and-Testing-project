using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    /*
     * Using Nuget Manager install
     * 1. NUnit
     * 2. NUnit3TestAdapter
     * 3.  Moq
     * For it to work
     */
    public class InsuranceService
    {
            public IDiscountService _discountService;      //For part i - Injecting the dependency

            public InsuranceService(IDiscountService discountService)
            {
                _discountService = discountService;
            }

            public double CalcPremium(int age, string gameMode)
            {
                double premium;

                if (gameMode == "casual")
                    if ((age >= 18) && (age < 30))
                        premium = 5.0;
                    else
                        if (age >= 31)
                        premium = 2.50;
                    else
                        premium = 0.0;
                else if (gameMode == "hardcore")
                    if ((age >= 18) && (age <= 35))
                        premium = 6.0;
                    else if (age >= 36)
                        premium = 5.0;
                    else
                        premium = 0.0;
                else
                    premium = 0.0;

                //DiscountService ds = new DiscountService();  // tightly coupled
                //double discount = ds.GetDiscount();

                //decoupled version
                double discount = _discountService.GetDiscount();  //For part i - Injecting the dependency
                if (age >= 50)
                    premium = premium * discount;

                return premium;
            }
        }
    }
