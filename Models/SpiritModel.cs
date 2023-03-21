using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WPFThreeDogsDistillery2.Models
{
    public class SpiritModel
    {

        public SpiritModel(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Name + " - " + Description;
        }

    }

}
