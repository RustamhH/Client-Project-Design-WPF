using Client_Project_Design.Commands;
using Client_Project_Design.Models;
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
            WindowMaker.MakeWindow<NewClientView, HomeView>();
        }


        public NewClientViewModel()
        {
            LoginCommand = new(LogIn);
        }

        



    }
}
