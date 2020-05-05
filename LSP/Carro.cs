using System;
using SOLID.OCP.LSP;

namespace SOLID.LSP
{
    public class Carro : Veiculo
    {
        public override void LigarMotor()
        {
            Console.WriteLine("Motor ligado (filho)");
        }
    }
}