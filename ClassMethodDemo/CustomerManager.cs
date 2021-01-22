using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer added: " + customer.name + " " + customer.surName );
        }
        public void ListCustomers(Customer customer)
        {
            Console.WriteLine("Customer listed: " + customer.name + " " + customer.surName );
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer deleted: " + customer.Id );
        }
        public void EditBalance(Customer customer)
        {
            Console.WriteLine("Balance edited: " + customer.balance);
        }
    }
}
