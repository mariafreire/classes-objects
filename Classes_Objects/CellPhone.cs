using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Objects
{
    class CellPhone
    {
        private float _screenSize;
        private string _operatingSystem;
        private System.Drawing.Color _color;
        public float ScreenSize
        {
            get
            {
                return _screenSize;
            }
            set
            {
                _screenSize = value;
            }
        }
        public string OperatingSystem
        {
            get
            {
                return _operatingSystem;
            }
            set
            {
                _operatingSystem = value;
            }
        }
        public string Model
        {
            get; set;
        }
        public System.Drawing.Color PhoneColor
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        
        public double RetailPrice
        {
            get; set;
        }
        public double discount(double percentage)
        {
            if (percentage > 0 && percentage < 1)
            {
                return RetailPrice * percentage;
            }
            else
            {
                return 0;
            }
        }
        public string PhoneInfo()
        {
            return "Model: " + Model + Environment.NewLine +
                "Screen: " + _screenSize.ToString("N1") + " inch" + Environment.NewLine +
                "Color " + _color.ToString() + Environment.NewLine +
                "Retain price: " + RetailPrice.ToString("c2");
        }
        public CellPhone()
        {
            PhoneInfo();
        }
        public CellPhone(string m)
        {
            Model = m;
        }
        public CellPhone(string m, System.Drawing.Color c, float s, double p)
        {
            Model = m;
            _color = c;
            _screenSize = s;
            RetailPrice = p;
        }
    }
}
