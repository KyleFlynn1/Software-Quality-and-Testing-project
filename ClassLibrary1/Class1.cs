using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        class InsuranceService
        {
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

                DiscountService ds = new DiscountService();  // tightly coupled
                double discount = ds.GetDiscount();
                if (age >= 50)
                    premium = premium * discount;

                return premium;
            }
        }
    }
}
