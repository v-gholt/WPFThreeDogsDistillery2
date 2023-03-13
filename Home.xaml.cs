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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();
            this.NavigationService.Navigate(order);
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void PageListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ListBoxItem_Selected_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
