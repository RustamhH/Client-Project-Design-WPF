﻿using Client_Project_Design.DB;
using Client_Project_Design.Models;
using Client_Project_Design.ViewModels;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for AllClientsView.xaml
    /// </summary>
    public partial class AllClientsView : Window
    {
        public AllClientsView()
        {
            InitializeComponent();
            DataContext = new AllClientsViewModel();
        }

        

        private void ClientsListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Client deleted = ClientsListView.SelectedItem as Client;
            
            if(MessageBox.Show("Are you sure?", "Warning", MessageBoxButton.YesNo, MessageBoxImage.Warning)==MessageBoxResult.Yes)
            {
                ClientsDB.Clients.Remove(deleted);
                JsonFileHandler.Write("Clients.json", ClientsDB.Clients);

            }

        }
    }
}
