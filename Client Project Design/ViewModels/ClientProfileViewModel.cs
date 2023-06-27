using Client_Project_Design.Commands;
using Client_Project_Design.Models;
using Client_Project_Design.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_Project_Design.ViewModels
{
    public class ClientProfileViewModel
    {

        public RealCommand NewCommand { get; set; }

        public ClientProfileViewModel()
        {
            NewCommand = new(New);
        }


        public void New(object?param)
        {
            WindowMaker.MakeWindow<ClientProfileView, NewOrderView>();
        }
    }
}
