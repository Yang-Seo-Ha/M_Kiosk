using System;
using System.Collections.Generic;
using System.Text;


namespace 키오스크.Models
{
    public class MenuItem
    {
        public string id { get; set; }
        public string category { get; set; }
        public string rawText { get; set; }
        public string name_ko { get; set; }
        public string name_en { get; set; }
        public string kcal { get; set; }
        public string url { get; set; }
        public string imageUrl { get; set; }
    }
}


