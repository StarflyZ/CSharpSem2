using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StevenEmployeeWageSystem
{
    public class StevenTemporary : StevenEmployee
    {
        #region DATA MEMBER
        private DateTime startingWorkDate;
        private DateTime endWorkDate;
        #endregion

        #region CONSTRUCTOR
        public StevenTemporary(string employeeId,string employeeName, int basicSalary,
            DateTime startingWorkDate, DateTime endWorkDate) : base(employeeId,employeeName,basicSalary)
        {
            StartingWorkDate = startingWorkDate;
            EndWorkDate = endWorkDate;
        }
        #endregion

        #region PROPERTIES
        public DateTime StartingWorkDate { get => startingWorkDate; set => startingWorkDate = value; }
        public DateTime EndWorkDate { get => endWorkDate; set => endWorkDate = value; }
        #endregion

        #region METHODS
        public override string Display()
        {
            string data = base.Display() + "\nStarting Working Date : " + StartingWorkDate.ToShortDateString()
                + "\nEnding Working Date : " + EndWorkDate.ToShortDateString()+"\nBonus : " + CalculateBonus()
                +"\n";
            return data;
        }

        public double CalculateBonus()
        {
            int numAttendace = (EndWorkDate.Date).Subtract(StartingWorkDate.Date).Days;
            double bonus = 0.1 * BasicSalary + numAttendace * 0.01 * BasicSalary;
            return bonus;
        }
        #endregion
    }
}