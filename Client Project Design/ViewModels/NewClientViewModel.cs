using Client_Project_Design.Commands;
using Client_Project_Design.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Client_Project_Design.ViewModels
{
    public class NewClientViewModel
    {

        public RealCommand? LoginCommand { get; set; }



        public void LogIn(object? param)
        {
            try
            {
                object temp = App.Current.MainWindow; // home view
                HomeView hv = new();
                App.Current.MainWindow.Hide();
                App.Current.MainWindow= hv;
                hv.ShowDialog();
                App.Current.MainWindow = temp as NewClientView;
                App.Current.MainWindow.ShowDialog();
            }
            catch(Exception ex) { }
        }


        public NewClientViewModel()
        {
            LoginCommand = new(LogIn);
        }

        



    }
}
