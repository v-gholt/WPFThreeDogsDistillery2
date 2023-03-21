using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFThreeDogsDistillery2.Models
{
    public class FontColorModel
    {
        public FontColorModel(string name, string color)
        {
            Name = name;
            Color = color;
        }
        public string Name { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
