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

namespace Client_Project_Design.Models
{
    public class Client:INotifyPropertyChanged
    {


        public ObservableCollection<Order> Orders { get; set; } = new();


        private Guid _id;

		public Guid Id
		{
			get { return _id; }
			set { _id = value; OnChangeProperty(); }
		}

		private string? _company;

		public string? Company
		{
			get { return _company; }
			set { _company = value; OnChangeProperty(); }
		}


        private string? _name;

        public string? Name
        {
            get { return _name; }
            set { _name = value; OnChangeProperty(); }
        }


        private string? _surname;

        public string? Surname
        {
            get { return _surname; }
            set { _surname = value; OnChangeProperty(); }
        }



        private string? _place;

        public string? Place
        {
            get { return _place; }
            set { _place = value; OnChangeProperty(); }
        }


        private string? _number;

        public string? Number
        {
            get { return _number; }
            set 
            {
                if (!Regex.IsMatch(value!, "^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{2}[-\\s\\.]?[0-9]{2}$")) MessageBox.Show("Invalid Number"); 
                else _number = value; OnChangeProperty(); 
            }
        }


        private string? _howdoIknow;

        public string? HowDoIKnow
        {
            get { return _howdoIknow; }
            set { _howdoIknow = value; OnChangeProperty(); }
        }




        private DateTime _reg;

        public DateTime RegistrationDate
        {
            get { return _reg; }
            set { _reg = value; OnChangeProperty(); }
        }



        public event PropertyChangedEventHandler? PropertyChanged;


        private void OnChangeProperty([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public Client()
        {

        }


        public Client(Guid id, string? company, string? name,string?surname, string? place, string? number,string?how, DateTime registrationDate)
        {
            Id = id;
            Company = company;
            Name = name;
            Surname = surname;
            Place = place;
            HowDoIKnow = how;
            Number = number;
            RegistrationDate = registrationDate;
        }
    }
}
