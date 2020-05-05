using System;

namespace SOLID.SRP.Repository
{
    public class FornecedorRepository : IFornecedorRepository
    {
        public void Salvar(Fornecedor fornecedor)
        {
            Console.WriteLine("salvei");
        }
    }
}