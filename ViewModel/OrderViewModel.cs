using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml.Linq;
using WPFThreeDogsDistillery2.Models;

namespace WPFThreeDogsDistillery2.ViewModel
{
    public class OrderViewModel : INotifyPropertyChanged
    {
        //CartState _CartState = new CartState();

        //public List<BottleModel> CartItems
        //{
        //    get { return _CartState.GetCartItems(); }
        //}
        //public void AddSelectedSpiritToCart_Click(object sender, RoutedEventArgs e)
        //{
        //    _CartState.AddCartItem(new BottleModel(SelectedSpirit, SelectedFlavor, SelectedQuantity));
        //}

        private SpiritModel? _selectedSpirit;
        public SpiritModel? SelectedSpirit 
        {
            get { return _selectedSpirit; }

            set
            {
                if (_selectedSpirit != value)
                {
                    _selectedSpirit = value;
                    OnPropertyChanged();
                    //CartState.AddCartItem(new BottleModel { Spirit = SelectedSpirit });
                }
            }
        }

        private FlavorModel? _selectedFlavor;
        public FlavorModel? SelectedFlavor
        {
            get { return _selectedFlavor; }

            set
            {
                if (_selectedFlavor != value)
                {
                    _selectedFlavor = value;
                    OnPropertyChanged(nameof(SelectedFlavor));
                    FontFamilies = SelectedFlavor?.FontFamilies ?? new List<FontFamilyModel>();
                    OnPropertyChanged(nameof(SelectedFlavor.FontFamilies));
                };
            }
        }

        public int MaxWhiskeyBottles { get; set; } = 2;

        private QuantityModel? _selectedQuantity;
        public QuantityModel? SelectedQuantity
        {
            get { return _selectedQuantity; }

            set
            {
                if (SelectedSpirit?.Name == "Whiskey" && value?.Quantity > MaxWhiskeyBottles)
                {
                    MessageBox.Show($"Sorry, you can only order up to {MaxWhiskeyBottles} bottles of whiskey.");
                }
                else if (_selectedQuantity != value)
                {
                    _selectedQuantity = value;
                    OnPropertyChanged();
                }
            }
        }

        private FontFamilyModel? _selectedFontFamily;
        public FontFamilyModel? SelectedFontFamily
        {
            get { return _selectedFontFamily; }

            set
            {
                if (_selectedFontFamily != value)
                {
                    _selectedFontFamily = value;
                    OnPropertyChanged();
                }
            }
        }

        private FontColorModel? _selectedFontColor;
        public FontColorModel? SelectedFontColor
        {
            get { return _selectedFontColor; }

            set
            {
                if (_selectedFontColor != value)
                {
                    _selectedFontColor = value;
                    OnPropertyChanged();
                }
            }
        }

        private List<CartModel> _cart = new List<CartModel>();

        public List<CartModel> Cart
        {
            get => _cart;
            set
            {
                if (value != _cart)
                {
                    _cart = value;
                    OnPropertyChanged(nameof(Cart));
                }
            }
        }

        //public void AddToCart(CartModel cartItem)
        //{
        //    _cart.Add(cartItem);
        //    OnPropertyChanged(nameof(Cart));
        //}


        //class CartState
        //{
        //    List<BottleModel> _CartItems = new List<BottleModel>();

        //    public void AddCartItem(BottleModel cartItem)
        //    {
        //        _CartItems.Add(cartItem);
        //    }

        //    public void RemoveCartItem(int index)
        //    {
        //        _CartItems.RemoveAt(index);
        //    }

        //    public List<BottleModel> GetCartItems()
        //    {
        //        return _CartItems;
        //    }
        //}

        public List<SpiritModel> Spirits { get; set; } = new () 
        {
            new SpiritModel("Brandy", "Made from all natural fruits and quality sugar. Fermented for 30 days."),
            new SpiritModel("Whiskey", "Made from barley and grains. Fermented for 30 days. Aged with chips for 30 days."),
            new SpiritModel("Vodka", "Made from wheat, rye, or potato. Fermented for 30 days. Triple distilled."),
        };

        public List<FlavorModel> Flavors { get; set; } = new()
        {
            new FlavorModel("Cherry", "/cherry.jpg", new List<FontFamilyModel>
            {
                new FontFamilyModel("Arial", "Arial"),
                new FontFamilyModel("Segoe", "Segoe"),
                new FontFamilyModel("Wingdings", "Wingdings")
            }),
            new FlavorModel("Apple", "/apple.jpg", new List<FontFamilyModel>
            {
                new FontFamilyModel("Monaco", "Monaco"),
                new FontFamilyModel("Papyrus", "Papyrus"),
                new FontFamilyModel("Gothic", "Gothic")
            }),
            new FlavorModel("Watermelon Candy", "/candy.jpg", new List<FontFamilyModel>
            {
                new FontFamilyModel("Cambria", "Cambria"),
                new FontFamilyModel("Courier", "Courier"),
                new FontFamilyModel("Times New Roman", "Times New Roman")
            }),
        };

        public List<QuantityModel> Quantities { get; set; } = new()
        {
            new QuantityModel(1),
            new QuantityModel(2),
            new QuantityModel(3),
        };

        //public List<LabelModel> Labels { get; set; } = new()
        //{
        //    new LabelModel("Geiselle's Bottle"),
        //};

        //public List<FontFamilyModel> FontFamilies => SelectedFlavor?.FontFamilies ?? new List<FontFamilyModel>();
        public List<FontFamilyModel>? FontFamilies { get; set; }


        public List<FontColorModel> FontColors { get; set; } = new()
        {
            new FontColorModel("Red", "Red"),
            new FontColorModel("Blue", "Blue"),
            new FontColorModel("Green", "Green"),
        };



        public event PropertyChangedEventHandler? PropertyChanged;


        protected void OnPropertyChanged([CallerMemberName] string propertyName = null!)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }

}
