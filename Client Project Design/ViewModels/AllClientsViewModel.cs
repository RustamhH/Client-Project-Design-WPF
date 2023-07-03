using Client_Project_Design.Commands;
using Client_Project_Design.DB;
using Client_Project_Design.Models;
using Client_Project_Design.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Client_Project_Design.ViewModels
{
    public class AllClientsViewModel
    {
        public ObservableCollection<Client> Clients { get; set; } = new();
        public RealCommand BackToHomeCommand { get; set; }
        public RealCommand NewCommand { get; set; }
        public RealCommand MoreCommand { get; set; }



        public AllClientsViewModel()
        {
            Clients = ClientsDB.Clients!;
            
            BackToHomeCommand = new(BackToHome);
            NewCommand = new(New);
            MoreCommand = new(More);
        }



       
        public void BackToHome(object? param)
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
            catch (Exception ex) { }
        }

        public void New(object?param)
        {
            NewClientRegisterViewModel.forEdit = false;
            WindowMaker.MakeWindow<AllClientsView, NewClientRegisterView>();
        }

        public void More(object? param)
        {
            if(param is Client cl)
            {
                ClientProfileViewModel.SelectedClient = cl;
            }
            
            WindowMaker.MakeWindow<AllClientsView, ClientProfileView>();
        }



    }
}
