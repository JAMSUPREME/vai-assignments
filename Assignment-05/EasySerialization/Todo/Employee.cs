namespace EasySerialization.Todo
{
    public class Employee : Human
    {
        public double Salary { get; set; }

        public string SalaryDisplay { get { return Salary.ToString("C"); } set { } }
    }
}
