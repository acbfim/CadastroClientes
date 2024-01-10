using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadastroClientes.Models
{
    public interface IBaseObject
    {
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
    }
}