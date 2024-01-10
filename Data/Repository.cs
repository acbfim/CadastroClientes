using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CadastroClientes.Extensions;
using CadastroClientes.Models;

namespace CadastroClientes.Data
{
    public static class Repository
    {
        private static List<Customer> customers;
        private static List<Contact> contacts = [];

        private static void InitializeIfNeeded()
        {
            if(customers is null)
                customers = [];
        }

        private static int GetNextId<T>(this List<T> obj) where T : IBaseObject
        {
            var newId = obj.Any() ? obj.Max(x => x.Id) + 1 : 1;
            return newId;
        }

        public static void AddCustomer(string nome, int idade, string contato)
        {
            InitializeIfNeeded();

            var id = customers.GetNextId();

            var customer = new Customer
            {
                Id = id,
                Idade = idade,
                Name = nome
            };

            var contact = new Contact
            {
                Value = contato,
                CustomerId = customer.Id
            };

            var createdContact = CreateContact(contact);

            customer.Contacts.Add(createdContact);

            customers.Add(customer);
        }

        private static Contact CreateContact(Contact contact)
        {
            contact.Id = contacts.GetNextId();
            contacts.Add(contact);

            return contact;
        }

        public static List<CustomerResponse> GetAllCustomer() => 
            customers.Select(x => x.AsCustomerResponse()).ToList();
        
    }
}