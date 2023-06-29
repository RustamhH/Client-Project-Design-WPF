using Client_Project_Design.DB;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace Client_Project_Design.Models
{
    public class Client
    {


        public ObservableCollection<Order> Orders { get; set; } = new();


       

        private Guid _id;

		public Guid Id
		{
			get { return _id; }
			set { _id = value;  }
		}

		private string? _company;

		public string? Company
		{
			get { return _company; }
			set { if (string.IsNullOrEmpty(value)) throw new Exception("Invalid Company"); 
                _company = value;  }
		}


        private string? _name;

        public string? Name
        {
            get { return _name; }
            set { if (string.IsNullOrEmpty(value)) throw new Exception("Invalid Name"); 
                _name = value;  }
        }


        private string? _surname;

        public string? Surname
        {
            get { return _surname; }
            set { if (string.IsNullOrEmpty(value)) throw new Exception("Invalid Surname"); 
                _surname = value;  }
        }



        private string? _place;

        public string? Place
        {
            get { return _place; }
            set {if (string.IsNullOrEmpty(value)) throw new Exception("Invalid Place");
                _place = value;  }
        }


        private string? _number;

        public string? Number
        {
            get { return _number; }
            set 
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("Invalid Number");
                if (!Regex.IsMatch(value!, "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{2}[-\\s\\.]?[0-9]{2}$")) throw new Exception("Invalid Number");
                _number = value; 
            }
        }


        private string? _howdoIknow;

        public string? HowDoIKnow
        {
            get { return _howdoIknow; }
            set { if (string.IsNullOrEmpty(value)) throw new Exception("Invalid HowDoIKnow"); 
                _howdoIknow = value; }
        }




        private DateTime _reg;

        public DateTime RegistrationDate
        {
            get { return _reg; }
            set { _reg = value; }
        }





        


        public string Regs { get; set; }



        public Client()
        {
           
        }


        public Client(Guid id,  string? name, string? surname, string? number, string? place, string? company , string day,string month,string year,string ?how):this()
        {
            Id = id;
            Name = name;
            Surname = surname;
            Number = number;
            Company = company;
            Place = place;
            RegistrationDate = new(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day));
            Regs = RegistrationDate.ToShortDateString();
            HowDoIKnow = how;
        }
    }
}
