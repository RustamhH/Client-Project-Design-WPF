using Client_Project_Design.Commands;
using Client_Project_Design.Models;
using Client_Project_Design.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Client_Project_Design.ViewModels
{
    public class ClientProfileViewModel
    {

        public RealCommand NewCommand { get; set; }
        public RealCommand EditCommand { get; set; }
        public RealCommand BackToHomeCommand { get; set; }

        public RealCommand EditOrderCommand { get; set; }

        public static Client? SelectedClient { get; set; } = new();
        public static Order? SelectedOrder { get; set; } = new();

        

        public ClientProfileViewModel()
        {
            NewCommand = new(New);
            EditCommand = new(Edit);
            EditOrderCommand = new(EditOrder);
            BackToHomeCommand = new(BackToHome);
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
            WindowMaker.MakeWindow<ClientProfileView, NewOrderView>();
        }


        public void Edit(object?param)
        {
            NewClientRegisterViewModel.forEdit = true;
            WindowMaker.MakeWindow<ClientProfileView, NewClientRegisterView>();
        }

        public void EditOrder(object? param)
        {
            if(param is Order or)
            {
                SelectedOrder = or;
            }
            NewOrderViewModel.forEdit = true;
            WindowMaker.MakeWindow<ClientProfileView, NewOrderView>();
        }











    }
}
