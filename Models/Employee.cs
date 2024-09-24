namespace webcruddotnetcore.Models
{
    public class Employee
    {
        public int Id { get; set; }  // Auto-increment primary key
        public string? Name { get; set; }  // Nullable Text field
        public decimal? Salary { get; set; }  // Nullable Decimal field
        public DateTime? Dob { get; set; }  // Nullable Date of birth (datetime)
    }
}
