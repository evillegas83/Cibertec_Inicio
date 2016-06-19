using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class EmployeeData : BaseDataAccess<Employee>
    {
        public Employee GetEmployeeById(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return dbContext.Employees.Find(id);
            }
        }
    }
}