using Bogus;
using Client_Project_Design.Models;
using MVVM.Db;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Client_Project_Design.DB
{
    public class ClientsDB
    {
        public static ObservableCollection<Client>? Clients { get; set; } = new();

        public ClientsDB()
        {
            
            
        }

        


        

        
    }
}
