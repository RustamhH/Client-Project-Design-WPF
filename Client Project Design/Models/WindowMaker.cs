using Client_Project_Design.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Client_Project_Design.Models
{
    public static class WindowMaker
    {
        public static void MakeWindow<OldWindow,NewWindow>() where NewWindow :Window,new() where OldWindow:Window,new()
        {
            try
            {
                object temp = App.Current.MainWindow;
                NewWindow ncrv = new NewWindow();
                App.Current.MainWindow.Hide();
                App.Current.MainWindow = ncrv;
                ncrv.ShowDialog();
                App.Current.MainWindow = temp as OldWindow;
                App.Current.MainWindow.ShowDialog();
            }
            catch(Exception ex) { }
        }
    }
}
