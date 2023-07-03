using Bogus.DataSets;
using Client_Project_Design.Commands;
using Client_Project_Design.DB;
using Client_Project_Design.Models;
using Client_Project_Design.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Client_Project_Design.ViewModels
{
    public class NewClientRegisterViewModel
    {
        public RealCommand BackToHomeCommand { get; set; }
        public RealCommand RegisterCommand { get; set; }


        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }
        public string Company { get; set; }
        public string Place { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public string How { get; set; }

        public static bool forEdit { get; set; }

        public NewClientRegisterViewModel()
        {
            if(forEdit)
            {
                Name = ClientProfileViewModel.SelectedClient.Name;
                Surname = ClientProfileViewModel.SelectedClient.Surname;
                Number = ClientProfileViewModel.SelectedClient.Number;
                Company = ClientProfileViewModel.SelectedClient.Company;
                Place = ClientProfileViewModel.SelectedClient.Place;
                Day = ClientProfileViewModel.SelectedClient.RegistrationDate.Day.ToString();
                Month = ClientProfileViewModel.SelectedClient.RegistrationDate.Month.ToString();
                Year = ClientProfileViewModel.SelectedClient.RegistrationDate.Year.ToString();
                How = ClientProfileViewModel.SelectedClient.HowDoIKnow;
            }
            BackToHomeCommand = new(BackToHome);
            RegisterCommand = new(Register);
        }


        public void Register(object?param)
        {
            if(!forEdit)
            {
                try
                {
                    Client client = new(Guid.NewGuid(), Name, Surname, Number, Place, Company,Day,Month,Year,How);
                    ClientsDB.Clients.Add(client);
                    JsonFileHandler.Write("Clients.json", ClientsDB.Clients);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); return; }

            }
            else
            {
                try
                {
                    ClientProfileViewModel.SelectedClient.Name = Name;
                    ClientProfileViewModel.SelectedClient.Surname = Surname;
                    ClientProfileViewModel.SelectedClient.Number = Number;
                    ClientProfileViewModel.SelectedClient.Company = Company;
                    ClientProfileViewModel.SelectedClient.Place = Place;
                    ClientProfileViewModel.SelectedClient.RegistrationDate= new(Convert.ToInt32(Year), Convert.ToInt32(Month),Convert.ToInt32(Day));
                    ClientProfileViewModel.SelectedClient.HowDoIKnow = How;
                }
                catch(Exception ex) { MessageBox.Show(ex.Message);return; }
            }
            WindowMaker.MakeWindow<NewClientRegisterView, AllClientsView>();
        }

        public void BackToHome(object?param)
        {
            try
            {
                NewClientView ncv = new();
                App.Current.MainWindow.Close();
                App.Current.MainWindow = ncv; // new client register
                ncv.ShowDialog();
                Application.Current.Windows.Cast<Window>()
                .Where(window => window.Visibility == Visibility.Hidden)
                .ToList()
                .ForEach(window => window.Close());
            }
            catch(Exception ex) { }
        }


    }
}
