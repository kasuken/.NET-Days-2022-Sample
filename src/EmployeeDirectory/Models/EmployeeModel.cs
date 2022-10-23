namespace EmployeeDirectory.Models
{
    public class EmployeeModel
    {
        public Guid ID { get; set; }
        public DateTime Joined { get; set; }
        public string Name { get; set; } = "";
        public string Image { get; set; } = "";
        public string Email { get; set; } = "";
        public string JotTitle { get; set; } = "";
        public string Department { get; set; } = "";
    }
}
