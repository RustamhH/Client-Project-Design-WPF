using Client_Project_Design.Commands;
using Client_Project_Design.Models;
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
        public RealCommand? AllClientsCommand { get; set; }



        public void NewClient(object? param)
        {
            WindowMaker.MakeWindow<HomeView, NewClientRegisterView>();
        }

        public void AllClients(object? param)
        {
            WindowMaker.MakeWindow<HomeView, AllClientsView>();
        }

        public HomeViewModel()
        {
            NewClientCommand = new(NewClient);
            AllClientsCommand = new(AllClients);
        }
    }
}
