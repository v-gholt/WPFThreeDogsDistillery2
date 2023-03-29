using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFThreeDogsDistillery2.Models
{
    public class CartModel
    {
        public List<CartItem> Items { get; set; }

        public CartModel()
        {
            Items = new List<CartItem>();
        }

        public void AddToCart(SpiritModel? selectedSpirit, FlavorModel? selectedFlavor, QuantityModel? selectedQuantity)
        {
            Items.Add(new CartItem(selectedSpirit, selectedFlavor, selectedQuantity));
        }
    }

    public class CartItem
    {
        public SpiritModel? SelectedSpirit { get; }
        public FlavorModel? SelectedFlavor { get; }
        public QuantityModel? SelectedQuantity { get; }

        public CartItem(SpiritModel? selectedSpirit, FlavorModel? selectedFlavor, QuantityModel? selectedQuantity)
        {
            SelectedSpirit = selectedSpirit;
            SelectedFlavor = selectedFlavor;
            SelectedQuantity = selectedQuantity;
        }
        public override string ToString()
        {
            return SelectedQuantity?.Quantity + " x " + SelectedFlavor?.Name + SelectedSpirit?.Name;
        }
    }
}
