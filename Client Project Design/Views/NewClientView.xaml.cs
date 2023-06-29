using Client_Project_Design.DB;
using Client_Project_Design.Models;
using Client_Project_Design.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Client_Project_Design.Views
{
    /// <summary>
    /// Interaction logic for NewClientView.xaml
    /// </summary>

    static class Worked { public static bool WorkedAlready { get; set; } = false; }

    public partial class NewClientView : Window
    {
        public NewClientView()
        {
            InitializeComponent();
            DataContext = new NewClientViewModel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(Worked.WorkedAlready==false)
            {
                try
                {
                    ClientsDB.Clients= JsonFileHandler.Read<ObservableCollection<Client>>("Clients.json");
                }
                catch(Exception x) { ClientsDB.Clients = new(); }
                Worked.WorkedAlready = true;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            JsonFileHandler.Write("Clients.json",ClientsDB.Clients);
        }

        

    }
}
