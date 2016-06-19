using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class WebDeveloperInitializer : DropCreateDatabaseAlways<WebContextDb>
    {
        protected override void Seed(WebContextDb context)
        {
            var clients = new List<Client>
            {
                new Client {Name = "Jose", LastName = "Perez" },
                new Client {Name = "Juan", LastName = "Perez" },
                new Client {Name = "Maria", LastName = "Perez" },
                new Client {Name = "Pedro", LastName = "Perez" },
                new Client {Name = "Marcos", LastName = "Perez" },
                new Client {Name = "Lucas", LastName = "Perez" },
                new Client {Name = "Pablo", LastName = "Perez" },
                new Client {Name = "Mateo", LastName = "Perez" }
            };

            var employees = new List<Employee>
            {
                new Employee { Name= "Jorge" , LastName= "Rodriguez" , Address = "Calle Yauyos 717, Surco", BirthDate = Convert.ToDateTime("10-01-1989"), HireDate = Convert.ToDateTime("01-02-2000")},
                new Employee { Name= "Martha" , LastName= "Chavez" , Address = "Jr. Las Delicias 124, Miraflores", BirthDate = Convert.ToDateTime("02-06-1990") , HireDate = Convert.ToDateTime("06-01-2016")},
                new Employee { Name= "Sofia" , LastName= "Quispe" , Address = "Calle Las Miradas 852, Surquillo", BirthDate = Convert.ToDateTime("01-07-1990") , HireDate = Convert.ToDateTime("10-01-2015")},
                new Employee { Name= "Sandra" , LastName= "Villanueva" , Address = "Av Prolongación Piura 230, Lince", BirthDate = Convert.ToDateTime("10-12-1985") , HireDate = Convert.ToDateTime("12-08-2014")},
                new Employee { Name= "Simón" , LastName= "Huaman" , Address = "Av Las Américas 521, Los Olivos ", BirthDate = Convert.ToDateTime("01-02-1970") , HireDate = Convert.ToDateTime("13-02-2000")}
            };

            clients.ForEach(c => context.Clients.Add(c));
            employees.ForEach(e => context.Employees.Add(e));

            context.SaveChanges();

        }
    }
}
