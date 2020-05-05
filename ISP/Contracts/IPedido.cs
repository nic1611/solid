using System;

namespace SOLID.ISP.Contracts
{
    public interface IPedido
    {
        DateTime Data { get; set; }

        void RealizarPedido();
    }
}