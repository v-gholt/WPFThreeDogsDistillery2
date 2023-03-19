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
using WPFThreeDogsDistillery2.Models;

namespace WPFThreeDogsDistillery2
{
    /// <summary>
    /// Interaction logic for Order2.xaml
    /// </summary>
    public partial class Order2 : Page
    {

        private readonly BottleModel _bottleModel;

        public Order2()
        {
            InitializeComponent();
            _bottleModel = new BottleModel();
            // The DataContext serves as the starting point of Binding Paths
            DataContext = _bottleModel;
        }

        private void Button_Click_Home(object sender, RoutedEventArgs e)
        {
            Home2 home = new Home2();
            this.NavigationService.Navigate(home);
        }
        private void Button_Click_Spirit(object sender, RoutedEventArgs e)
        {

        }
        private void Button_Click_Flavor(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("");
        }
        private void Button_Click_Font(object sender, RoutedEventArgs e)
        {
            if (Arial.IsChecked == true)
            {
                MessageBox.Show("Arial");
            }
            else if (Cursive.IsChecked == true)
            {
                MessageBox.Show("Cursive");
            }
            else if (Fantasy.IsChecked == true)
            {
                MessageBox.Show("Fantasy");
            }
            else if (Courier.IsChecked == true)
            {
                MessageBox.Show("Courier");
            }
            else if (Roman.IsChecked == true)
            {
                MessageBox.Show("Roman");
            }
        }
        private void Button_Click_Color(object sender, RoutedEventArgs e)
        {
            if (Blue.IsChecked == true)
            {
                MessageBox.Show("Blue");
            }
            else if (Red.IsChecked == true)
            {
                MessageBox.Show("Red");
            }
            else if (Green.IsChecked == true)
            {
                MessageBox.Show("Green");
            }
            else if (Yellow.IsChecked == true)
            {
                MessageBox.Show("Yellow");
            }
            else if (Purple.IsChecked == true)
            {
                MessageBox.Show("Purple");
            }
        }
    }


}
