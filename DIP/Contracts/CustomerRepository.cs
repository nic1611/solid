using System;
using System.Data;

namespace SOLID.DIP.Contracts
{
    public class CustomerRepository : ICustomerRepository
    {
        public CustomerRepository()
        {

        }
        public void Save(string name)
        {
            Console.WriteLine(name);
        }
    }
}