namespace OpenClose
{
    public class EmployeeContractor
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public EmployeeContractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }  
    }
}