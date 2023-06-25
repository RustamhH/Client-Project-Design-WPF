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
using Client_Project_Design.ViewModels;

namespace Client_Project_Design.Views
{
    /// <summary>
    /// Interaction logic for NewClientRegisterView.xaml
    /// </summary>
    public partial class NewClientRegisterView : Window
    {
        public NewClientRegisterView()
        {
            InitializeComponent();
            DataContext = new NewClientRegisterViewModel();
        }

        
    }
}
