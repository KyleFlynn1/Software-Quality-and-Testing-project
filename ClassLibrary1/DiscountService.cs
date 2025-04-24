using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IDiscountService   //For part i - Injecting the dependency
    {
        double GetDiscount();
    }

    public class DiscountService : IDiscountService //For part i - Injecting the dependency
    {
        public double GetDiscount()
        {
            return 0.75;        //Returns * 0.75 which is 25% discount off the total price 
        }
    }
}
