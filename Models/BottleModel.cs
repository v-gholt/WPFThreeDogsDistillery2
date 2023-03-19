using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WPFThreeDogsDistillery2.Models
{
    public class BottleModel
    {
        private string? spirit;
        private string? flavor;
        private int quantity;

        public string Spirit
        {
            get
            {
                return spirit ?? string.Empty;
            }
            set
            {
                spirit = value;
            }
        }
        public string Flavor
        {
            get
            {
                return flavor ?? string.Empty;
            }
            set
            {
                flavor = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
    }
}

