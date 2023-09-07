using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDesafio
{

    public interface IProduct
    {
        int Id { get; set; }
        string Description { get; set; }
        int Cost { get; set; }
        int Price { get; set; }
        int Stock { get; set; }
        int IdUser { get; set; }

    }
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Description { get; set; }
        private int Cost { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public IUser User { get; set; }
        public int IdUser { get; set; }
        public Product() 
        {
            User = new User();
        }

    }
}
