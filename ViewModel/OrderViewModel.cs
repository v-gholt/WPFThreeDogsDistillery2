using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WPFThreeDogsDistillery2.Models;

namespace WPFThreeDogsDistillery2.ViewModel
{
    public class OrderViewModel
    {

        public List<SpiritModel> Spirits { get; set; } = new () 
        {
            new SpiritModel("Brandy", "Made from all natural fruits and quality sugar. Fermented for 30 days."),
            new SpiritModel("Whiskey", "Made from barley and grains. Fermented for 30 days. Aged with chips for 30 days."),
            new SpiritModel("Vodka", "Made from wheat, rye, or potato. Fermented for 30 days. Triple distilled."),
        };

        public List<FlavorModel> Flavors { get; set; } = new ()
        {
            new FlavorModel("Cherry", "/cherry.jpg"),
            new FlavorModel("Apple", "/apple.jpg"),
            new FlavorModel("Watermelon Candy", "/candy.jpg"),
        };

        public List<QuantityModel> Quantities { get; set; } = new()
        {
            new QuantityModel(1),
            new QuantityModel(2),
            new QuantityModel(3),
        };

        public List<LabelModel> Labels { get; set; } = new()
        {
            new LabelModel("Geiselle's Bottle"),
        };

        public List<FontFamilyModel> FontFamilies { get; set; } = new()
        {
            new FontFamilyModel("Arial", "Arial"),
            new FontFamilyModel("Roman", "Roman"),
            new FontFamilyModel("Fantasy", "Fantasy"),
        };

        public List<FontColorModel> FontColors { get; set; } = new()
        {
            new FontColorModel("Red", "Red"),
            new FontColorModel("Blue", "Blue"),
            new FontColorModel("Green", "Green"),
        };
    }
}
