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
using System.Windows.Media;

namespace Client_Project_Design.ViewModels
{
    public class NewOrderViewModel
    {
        public RealCommand BackToHomeCommand { get; set; }
        public RealCommand RegisterCommand { get; set; }



        public static bool forEdit { get; set; }

        public string DayO { get; set; }
        public string MonthO { get; set; }
        public string YearO { get; set; }

        public string OrderName { get; set; }
        public string OrderQuantity { get; set; }


        public string DayD { get; set; }
        public string MonthD { get; set; }
        public string YearD { get; set; }




        public NewOrderViewModel()
        {
            if (forEdit)
            {
                OrderName = ClientProfileViewModel.SelectedOrder.OrderName;
                OrderQuantity = ClientProfileViewModel.SelectedOrder.Quantity.ToString();
                DayO = ClientProfileViewModel.SelectedOrder.OpeningDate.Day.ToString();
                MonthO = ClientProfileViewModel.SelectedOrder.OpeningDate.Month.ToString();
                YearO = ClientProfileViewModel.SelectedOrder.OpeningDate.Year.ToString();
                DayD = ClientProfileViewModel.SelectedOrder.DeliveryDate.Day.ToString();
                MonthD = ClientProfileViewModel.SelectedOrder.DeliveryDate.Month.ToString();
                YearD = ClientProfileViewModel.SelectedOrder.DeliveryDate.Year.ToString();
            }
            BackToHomeCommand = new(BackToHome);
            RegisterCommand = new(Register);
        }

        

        public void Register(object?param)
        {
            if(forEdit)
            {
                try
                {
                    ClientProfileViewModel.SelectedOrder.OrderName = OrderName;
                    ClientProfileViewModel.SelectedOrder.Quantity = Convert.ToUInt32(OrderQuantity);
                    ClientProfileViewModel.SelectedOrder.OpeningDate= new(Convert.ToInt32(YearO), Convert.ToInt32(MonthO), Convert.ToInt32(DayO));
                    ClientProfileViewModel.SelectedOrder.DeliveryDate= new(Convert.ToInt32(YearD), Convert.ToInt32(MonthD), Convert.ToInt32(DayD));

                }
                catch(Exception ex) { MessageBox.Show(ex.Message);return; }



            }
            else
            {
                try
                {
                    Order order = new(Guid.NewGuid(), OrderName, Convert.ToUInt32(OrderQuantity), "21", "4", "2021", "20", "2", "2023",true);
                    ClientProfileViewModel.SelectedClient.Orders.Add(order);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); return; }
            }
            WindowMaker.MakeWindow<NewClientRegisterView, AllClientsView>();
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
    }
}
