using SOLID.DIP.Contracts;

namespace SOLID.DIP
{
    public class CustomerService
    {
        private ICustomerRepository rep;

        public CustomerService(ICustomerRepository rep)
        {
            this.rep = rep;
        }

        public void Register(string name)
        {
            rep.Save(name);
        }
    }
}