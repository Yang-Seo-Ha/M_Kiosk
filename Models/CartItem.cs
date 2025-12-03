using System;
using System.Collections.Generic;
using System.Text;

namespace 키오스크.Models
{
    public class CartItem
    {
        public MenuItem Item { get; set; }
        public int Quantity { get; set; }
    }
}
