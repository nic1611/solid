using SOLID.SRP.Services;

namespace SOLID.SRP
{
    public class Fornecedor
    {
        public int ID { get; private set; }
        public string Name { get; set; }

        public void ChangeName(string name)
        {
            this.Name = name;
            NotificationService.Notify("email@email.com");
        }
    }
}