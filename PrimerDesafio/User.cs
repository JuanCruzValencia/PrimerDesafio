using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDesafio
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Password { get; set; }
        string UserName { get; set; }

    }
    public class  User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}
