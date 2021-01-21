using System;

namespace Kpo4310.kim.Lib
{
    public class Accessory
    {
        public Accessory()
        {
            name = "";
            type = "";
            value = "";
            quantity = "";
        }

        public string name { get; set; }
        public string type { get; set; }
        public string value { get; set; }
        public string quantity { get; set; }
    }
}
