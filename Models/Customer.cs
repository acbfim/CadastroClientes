using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Models
{
    public class Customer : BaseObject
    {
        public Customer()
        {
            if(Contacts is null)
                Contacts = [];
        }

        public string Name { get; set; }
        public int Idade { get; set; }
        public List<Contact> Contacts { get; set; }
    }
}