namespace EFCore_CodeFirstDemo.Models
{
    public class Department
    {
        //[key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }
    }
}
