using Client_Project_Design.Commands;
using Client_Project_Design.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Project_Design.ViewModels
{
    public class HomeViewModel
    {

        public RealCommand? NewClientCommand { get; set; }



        public void NewClient(object? param)
        {
            try
            {
                object temp = App.Current.MainWindow; // home view
                NewClientRegisterView ncrv = new();
                App.Current.MainWindow.Hide();
                App.Current.MainWindow = ncrv; // new client register
                ncrv.ShowDialog();
                App.Current.MainWindow = temp as HomeView;
                App.Current.MainWindow.ShowDialog();
            }
            catch(Exception ex) { }
        }
        public HomeViewModel()
        {
            NewClientCommand = new(NewClient);
        }
    }
}
