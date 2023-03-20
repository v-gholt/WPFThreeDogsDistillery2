using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFThreeDogsDistillery2.Models
{
    internal class LabelModel
    {
        private string? fontColor;
        private string? fontFamily;
        private string? labelName;

        public string FontColor
        {
            get
            {
                return fontColor ?? string.Empty;
            }
            set
            {
                fontColor = value;
            }
        }
        public string FontFamily
        {
            get
            {
                return fontFamily ?? string.Empty;
            }
            set
            {
                fontFamily = value;
            }
        }

        public string LabelName
        {
            get
            {
                return labelName ?? string.Empty;
            }
            set
            {
                labelName = value;
            }
        }
    }
}
