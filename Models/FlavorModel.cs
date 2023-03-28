using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace WPFThreeDogsDistillery2.Models
{
    public class FlavorModel
    {

        public FlavorModel(string name, string imagePath, List<FontFamilyModel> fontFamilies)
        {
            Name = name;
            ImagePath = imagePath;
            FontFamilies = fontFamilies;
        }
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public List<FontFamilyModel> FontFamilies { get; set; } = new List<FontFamilyModel>();

    }


}
