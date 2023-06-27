using Client_Project_Design.Commands;
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
            Clients.Add(new(Guid.NewGuid(),"Indigo","Yunis","Memmedov","Baku","051-394-08-59","Essek Ticaret",DateTime.Now));
            Clients.Add(new(Guid.NewGuid(),"Mastaga","Ehsen","Abdullazade","Baku","051-394-08-59", "Developer", DateTime.Now));
            Clients.Add(new(Guid.NewGuid(),"Azadliq","Ibrahim","Asadov","Baku","051-394-08-59", "Frontend", DateTime.Now));
            Clients.Add(new(Guid.NewGuid(),"Nizami","Meri","Meri","Baku","051-394-08-59", "Afgan Kole", DateTime.Now));
            BackToHomeCommand = new(BackToHome);
            NewCommand = new(New);
            MoreCommand = new(More);
        }



        public void More(object?param)
        {
            WindowMaker.MakeWindow<AllClientsView, ClientProfileView>();
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
            WindowMaker.MakeWindow<AllClientsView, NewClientRegisterView>();
        }



        

    }
}
