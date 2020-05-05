namespace SOLID.ISP.Contracts
{
    public interface IEndereco
    {
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public string Pais { get; set; }

    }
}