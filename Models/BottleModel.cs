using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPFThreeDogsDistillery2.Models
{
    public class Bottle : INotifyPropertyChanged
    {
        private string spirit;
        private string flavor;
        private int quantity;

        public string Spirit
        {
            get
            {
                return spirit;
            }
            set
            {
                spirit = value;
                OnPropertyChanged("Spirit");
            }
        }
        public string Flavor
        {
            get
            {
                return flavor;
            }
            set
            {
                flavor = value;
                OnPropertyChanged("Flavor");
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
                OnPropertyChanged("Quantity");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}

