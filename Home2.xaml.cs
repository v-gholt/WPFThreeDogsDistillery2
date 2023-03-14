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
    /// Interaction logic for Home2.xaml
    /// </summary>
    public partial class Home2 : Page
    {
        public Home2()
        {
            InitializeComponent();
        }

        private void Button_Click_Order(object sender, RoutedEventArgs e)
        {
            Order2 order = new Order2();
            this.NavigationService.Navigate(order);
        }
    }
}
