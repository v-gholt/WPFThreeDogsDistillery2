using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Media;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace WPFThreeDogsDistillery2.Models
{
    public class BottleModel
    {

        public BottleModel(SpiritModel? selectedSpirit, FlavorModel? selectedFlavor, QuantityModel? selectedQuantity)
        {
            SelectedSpirit = selectedSpirit;
            SelectedFlavor = selectedFlavor;
            SelectedQuantity = selectedQuantity;
        }

        public SpiritModel? SelectedSpirit { get; }
        public FlavorModel? SelectedFlavor { get; }
        public QuantityModel? SelectedQuantity { get; }

        public override string ToString()
        {
            return SelectedQuantity + " x " + SelectedFlavor + SelectedSpirit;
        }
    }
}

