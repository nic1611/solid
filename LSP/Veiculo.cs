using System;

namespace SOLID.OCP.LSP
{
    public abstract class Veiculo
    {
        public virtual void LigarMotor()
        {
            Console.WriteLine("Motor ligado (pai)");
        }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando (pai)");
        }
    }
}