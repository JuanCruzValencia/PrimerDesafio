using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDesafio
{
    public interface ISoldProduct
    {
        int Id { get; set; }
        IProduct Product { get; set; }
        int IdProduct { get; set; }
        int Stock { get; set; }
        ISales Sales { get; set; }
        int IdSales { get; set; }
    }
    public class SoldProduct: ISoldProduct
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int Stock { get; set; }
        public int IdSales { get; set; }
        public ISales Sales { get; set; }
        public IProduct Product { get; set; }
        public SoldProduct() 
        {
            Product = new Product();
            Sales = new Sales();
        }
    }
}
