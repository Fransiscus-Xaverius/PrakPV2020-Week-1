using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesPraktikumW1
{
    internal class Item
    {
        private string name;
        private string category;
        private int harga;

        public Item(string name, string category, int harga)
        {
            this.name=name;
            this.category=category;
            this.harga=harga;
        }

        public override string ToString()
        {
            string product = ""+name+" - "+category+" - Rp."+harga.ToString();
            return product;
        }
    }
}
