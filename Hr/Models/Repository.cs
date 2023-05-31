namespace Hr.Models
{
    public class Repository
    {
        private static List<Employess> employeeList = new List<Employess>();


        public static IEnumerable<Employess> GetEmployesses()
        {
            return employeeList;
        }

        public static void AddEmployee(Employess emp) {
        employeeList.Add(emp);
        }
    }
}
