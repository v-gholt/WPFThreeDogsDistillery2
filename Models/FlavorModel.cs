using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPFThreeDogsDistillery2.Models
{
    public class FlavorModel
    {

        public FlavorModel(string name, string imagePath)
        {
            Name = name;
            ImagePath = imagePath;
        }
        public string Name { get; set; }
        public string ImagePath { get; set; }

    }
}
