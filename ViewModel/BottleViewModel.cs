using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFThreeDogsDistillery2.Models;
using WPFThreeDogsDistillery2.Views;
using System.DirectoryServices.ActiveDirectory;
using System.Diagnostics.Metrics;
using System.Windows;

namespace WPFThreeDogsDistillery2.ViewModel
{
    public class BottleViewModel : INotifyPropertyChanged
    {
        private BottleModel bottle;

        public BottleViewModel(BottleModel bottle)
        {
            this.bottle = bottle;
        }

        public string Spirit
        {
            get { return bottle.Spirit; }
            set 
            { 
                if (bottle.Spirit != value)
                {
                    bottle.Spirit = value;
                    OnPropertyChanged("Spirit");
                }
            }
        }

        public string Flavor
        {
            get { return bottle.Flavor; }
            set
            {
                if (bottle.Flavor != value)
                {
                    bottle.Flavor = value;
                    OnPropertyChanged("Flavor");
                }
            }
        }

        public int Quantity
        {
            get { return bottle.Quantity; }
            set
            {
                if (bottle.Quantity != value)
                {
                    bottle.Quantity = value;
                    OnPropertyChanged("Quantity");
                }
            }
        }

        private void Button_Click_Order(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Spirit(object sender, RoutedEventArgs e)
        {
            OnPropertyChanged("Spirit");
        }
        private void Button_Click_Flavor(object sender, RoutedEventArgs e)
        {
            OnPropertyChanged("Flavor");
        }
        //private void Button_Click_Font(object sender, RoutedEventArgs e)
        //{
        //    if (Arial.IsChecked == true)
        //    {
        //        OnPropertyChanged("Font_Family");
        //    }
        //    else if (Cursive.IsChecked == true)
        //    {
        //        OnPropertyChanged("Font_Family");
        //    }
        //    else if (Fantasy.IsChecked == true)
        //    {
        //        OnPropertyChanged("Font_Family");
        //    }
        //    else if (Courier.IsChecked == true)
        //    {
        //        OnPropertyChanged("Font_Family");
        //    }
        //    else if (Roman.IsChecked == true)
        //    {
        //        OnPropertyChanged("Font_Family");
        //    }
        //}
        //private void Button_Click_Color(object sender, RoutedEventArgs e)
        //{
        //    if (Blue.IsChecked == true)
        //    {
        //        OnPropertyChanged("Font_Color");
        //    }
        //    else if (Red.IsChecked == true)
        //    {
        //        OnPropertyChanged("Font_Color");
        //    }
        //    else if (Green.IsChecked == true)
        //    {
        //        OnPropertyChanged("Font_Color;
        //    }
        //    else if (Yellow.IsChecked == true)
        //    {
        //        OnPropertyChanged("Font_Color");
        //    }
        //    else if (Purple.IsChecked == true)
        //    {
        //        OnPropertyChanged("Font_Color");
        //    }
        //}


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
