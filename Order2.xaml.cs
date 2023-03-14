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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFThreeDogsDistillery2
{
    /// <summary>
    /// Interaction logic for Order2.xaml
    /// </summary>
    public partial class Order2 : Page
    {
        public Order2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Home2 home = new Home2();
            this.NavigationService.Navigate(home);
        }
    }
}
