using Client_Project_Design.Commands;
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

        public NewClientRegisterViewModel()
        {
            BackToHomeCommand = new(BackToHome);
            RegisterCommand = new(Register);
        }


        public void Register(object?param)
        {
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
