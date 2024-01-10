using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Models
{
    public class Contact : BaseObject
    {
        public string Value { get; set; }
        public int CustomerId { get; set; }
    }
}