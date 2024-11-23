using System.ComponentModel.DataAnnotations;

namespace MtApp.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        [Key]
        [RegularExpression("[A-Z]{4}[0-9]{6}[A-Z0-9]{3}")]
        public string RFC { get; set; }
        public DateTime BornDate { get; set; }
        public EmployeeStatus Status { get; set; }
    }
}
