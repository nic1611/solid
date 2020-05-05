using System;
using SOLID.ISP.Contracts;

namespace SOLID.ISP
{
    public class NotaFiscal : IPedido, IEndereco
    {
        public DateTime Data { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }

        public void RealizarPedido()
        {
            throw new NotImplementedException();
        }
    }
}