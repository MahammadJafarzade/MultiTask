using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class AcerStore
    {
        public int id { get; set; }
        public string model { get; set; }
        public int price { get; set; }
        public AcerStore(int id, string model, int price)
        {
            this.id = id;
            this.model = model;
            this.price = price;
        }
    }
}
