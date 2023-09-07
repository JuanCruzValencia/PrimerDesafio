using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDesafio
{
    public interface ISales
    {
        int Id { get; set;  }
        string Comments { get; set; }
        int IdProduct { get; set; }
        IProduct Product { get; set; }
    }

    public class Sales : ISales
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public int IdProduct { get; set; }
        public IProduct Product { get; set; }
        public Sales() 
        {
            Product = new Product();
        }
    }
}
