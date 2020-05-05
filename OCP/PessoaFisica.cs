namespace SOLID.OCP
{
    public class PessoaFisica : Pessoa
    {
        public PessoaFisica(string name, string cpf) : base(name)
        {
            this.cpf = cpf;
        }

        public string cpf { get; set; }
    }
}