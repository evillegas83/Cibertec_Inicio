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

            clients.ForEach(c => context.Clients.Add(c));
            context.SaveChanges();

        }
    }
}
