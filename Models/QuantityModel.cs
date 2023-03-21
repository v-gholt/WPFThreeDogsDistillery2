using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFThreeDogsDistillery2.Models
{
    public class QuantityModel
    {

        public QuantityModel(int quantity)
        {
            Quantity = quantity;
        }
        public int Quantity { get; set; }

    }
}
