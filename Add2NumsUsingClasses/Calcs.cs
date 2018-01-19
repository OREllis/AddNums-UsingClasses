using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add2NumsUsingClasses
{
    class Calcs{
        //returns sum to main
        public int calcSum(int num1, int num2, int num3) {
            return num1 + num2 + num3;
        }

        //returns average after taking in parameter sum
        public double calcAvg(int sum) {
            return sum / 3.00;
        }
    }
}
