using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDpm
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double GetPrice(Cliente cliente)
        {
            if (cliente.IsPremium)
                return Price * 0.8;
            return Price;
        }

        public double GetPrice(ICliente cliente)
        {
            if (cliente.IsPremium)
                return Price * 0.8;
            return Price;
        }
    }
}
