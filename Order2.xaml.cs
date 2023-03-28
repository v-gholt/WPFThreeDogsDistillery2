using Microsoft.Win32;
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
using WPFThreeDogsDistillery2.ViewModel;

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
            // The DataContext serves as the starting point of Binding Paths
            DataContext = new OrderViewModel();
        }

        private void Button_Click_Home(object sender, RoutedEventArgs e)
        {
            Home2 home = new Home2();
            this.NavigationService.Navigate(home);
        }
        private void selectImageButton_Click(object sender, EventArgs e)
        {
            //using (OpenFileDialog dlg = new OpenFileDialog())
            //{
            //    dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";
            //    if (dlg.ShowDialog() == DialogResult.OK)
            //    {
            //        // Display the selected image in a PictureBox control
            //        Image image = Image.FromFile(dlg.FileName);
            //        pictureBox1.Image = image;
            //    }
            //}
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sender is TextBox textBox && textBox.Text.Length > 50)
            {
                textBox.Text = textBox.Text.Substring(0, 50);
                textBox.CaretIndex = textBox.Text.Length;
            }
        }


    }


}
