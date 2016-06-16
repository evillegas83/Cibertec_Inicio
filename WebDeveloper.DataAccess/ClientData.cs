using System;
using System.Collections.Generic;
using System.Linq;
using WebDeveloper.Model;

namespace WebDeveloper.DataAccess
{
    public class ClientData : BaseDataAccess<Client>
    {
        public Client GetClientById(int id)
        {
            using (var dbContext = new WebContextDb())
            {
                return  dbContext.Clients.FirstOrDefault(s => s.ID == id);
            }
            
        }       
    }
}
