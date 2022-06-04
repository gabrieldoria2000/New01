using System.Collections.Generic;
using System.Linq;

namespace New01.Models
{
    public class Clientes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }

        public Clientes()
        {
        }

        public Clientes(int id, string name, string email, DateTime dataNascimento)
        {
            Id = id;
            Name = name;
            Email = email;
            DataNascimento = dataNascimento;
        }
    }
}
