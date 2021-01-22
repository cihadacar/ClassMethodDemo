using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();
            Customer customer4 = new Customer();

            customer1.Id = 1000;
            customer1.name = "Cihad";
            customer1.surName="Acar";
            customer1.balance = 662;

            customer2.Id = 1001;
            customer2.name = "Tuana";
            customer2.surName = "Acar";
            customer2.balance = 208;
            
            customer3.Id = 1002;
            customer3.name = "Meryem";
            customer3.surName = "Acar";
            customer3.balance = 204;
            
            customer4.Id = 1003;
            customer4.name = "Azra";
            customer4.surName = "Acar";
            customer4.balance = 207;

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer1);
            customerManager.DeleteCustomer(customer2);
            customerManager.ListCustomers(customer3);
            customerManager.EditBalance(customer4);
        }
    }
}
