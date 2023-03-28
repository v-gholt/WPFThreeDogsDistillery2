using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Media;
using System.Runtime.CompilerServices;

namespace WPFThreeDogsDistillery2.Models
{
    public class BottleModel : INotifyPropertyChanged
    {

        private SpiritModel? _spirit;
        public SpiritModel? Spirit
        {
            get { return _spirit; }
               
            set
            {
                if (_spirit != value)
                {
                    _spirit = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private FlavorModel? _flavor;
        public FlavorModel? Flavor
        {
            get { return _flavor; }
            set
            {
                if (_flavor != value)
                {
                    _flavor = value;
                    OnPropertyChanged("Flavor");
                }
            }
        }

        private QuantityModel? _quantity;
        public QuantityModel? Quantity
        {
            get { return _quantity; }

            set
            {
                if (_quantity != value)
                {
                    _quantity = value;
                    OnPropertyChanged("Quantity");
                }
            }
        }

        private LabelModel? _label;
        public LabelModel? Label
        {
            get { return _label; }

            set
            {
                if (_label != value)
                {
                    _label = value;
                    OnPropertyChanged("Label");
                }
            }
        }

        private FontFamilyModel? _fontFamily;
        public FontFamilyModel? FontFamily
        {
            get { return _fontFamily; }

            set
            {
                if (_fontFamily != value)
                {
                    _fontFamily = value;
                    OnPropertyChanged("FontFamily");
                }
            }
        }

        private FontColorModel? _fontColor;
        public FontColorModel? FontColor
        {
            get { return _fontColor; }

            set
            {
                if (_fontColor != value)
                {
                    _fontColor = value;
                    OnPropertyChanged("FontColor");
                }
            }
        }

        //public BottleModel(SpiritModel spirit, FlavorModel flavor, QuantityModel quantity, LabelModel label, FontFamilyModel fontFamily, FontColorModel fontColor)
        //{
        //    Spirit = spirit;
        //    Flavor = flavor;
        //    Quantity = quantity;
        //    Label = label;
        //    FontFamily = fontFamily;
        //    FontColor = fontColor;
        //}


    }

    //public class PropertyDemo
    //{
    //    //private int Id;

    //    //public int GetId()
    //    //{
    //    //    return Id;
    //    //}

    //    //public void SetId(int id)
    //    //{
    //    //    Id = id;
    //    //}

    //    private int _id;
    //    public int Id
    //    {
    //        get
    //        {
    //            return _id;
    //        }
    //        set
    //        {
    //            _id = value;
    //        }
    //    }
    //}

    //public class PropertyConsumer
    //{
    //    PropertyDemo pd;

    //    public void PropUpdater()
    //    {
    //        pd.Id = -1;
    //        pd.SetId(-1);
    //    }
    //}
}

