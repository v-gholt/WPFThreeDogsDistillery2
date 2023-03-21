using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFThreeDogsDistillery2.Models
{
    public class FontFamilyModel
    {
        public FontFamilyModel(string name, string fontFamily)
        {
            Name = name;
            FontFamily = fontFamily;
        }
        public string Name { get; set; }
        public string FontFamily { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
