namespace StevenEmployeeWageSystem
{
    public class StevenEmployee
    {
        #region DATA MEMBER
        private string employeeId;
        private string employeeName;
        private int basicSalary;
        #endregion

        #region CONSTRUCTOR
        public StevenEmployee(string employeeId, string employeeName, int basicSalary)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            BasicSalary = basicSalary;
        }
        #endregion

        #region PROPERTIES
        public string EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public int BasicSalary { get => basicSalary; set => basicSalary = value; }
        #endregion

        #region METHODS

        public virtual string Display()
        {
            string data = "ID : " + EmployeeId + "\nName : " + EmployeeName + "\nBasic Salary : " + BasicSalary;
            return data;
        }

        #endregion
    }
}