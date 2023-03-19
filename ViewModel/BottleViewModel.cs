using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFThreeDogsDistillery2.Models;
using System.DirectoryServices.ActiveDirectory;

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

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
