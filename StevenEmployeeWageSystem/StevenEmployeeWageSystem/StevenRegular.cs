using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StevenEmployeeWageSystem
{
    public class StevenRegular : StevenEmployee
    {
        #region DATA MEMBER
        private int numOfChild;
        #endregion

        #region CONSTRUCTOR
        public StevenRegular(string employeeId, string employeeName, int basicSalary,int numOfChild) 
            : base(employeeId,employeeName,basicSalary)
        {
            NumOfChild = numOfChild;
        }
        #endregion

        #region PROPERTIES
        public int NumOfChild { get => numOfChild; set => numOfChild = value; }
        #endregion

        #region METHODS
        public override string Display()
        {
            string data = base.Display() + "\nNumber of Children : " + NumOfChild 
                + "\nBonus : " + CalculateBonus()+"\n";
            return data;
        }

        public double CalculateBonus()
        {
            int numberOfChild = NumOfChild;
            if (NumOfChild > 3)
            {
                numberOfChild = 3;
            }
            double childAllowace = numberOfChild * 0.2 * BasicSalary;
            double bonus = BasicSalary + childAllowace;
            return bonus;
        }
        #endregion
    }
}