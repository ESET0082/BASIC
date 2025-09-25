namespace EmployeeApi.Models
{
    public class Employee
    {
        public int Id { get; set; }          // Primary Key
        public string? Name { get; set; }
        public string? Department { get; set; }
        // Department
        public decimal Salary { get; set; }  // Salary
    }
}
