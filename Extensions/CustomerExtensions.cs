using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroClientes.Models;

namespace CadastroClientes.Extensions
{
    public static class CustomerExtensions
    {
        public static CustomerResponse AsCustomerResponse(this Customer customer) => 
            new CustomerResponse
            {
                Idade = customer.Idade,
                Name = customer.Name
            };
        
    }
}