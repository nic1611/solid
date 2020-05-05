﻿using System;
using SOLID.LSP;
using SOLID.OCP;
using SOLID.SRP;
using SOLID.SRP.Repository;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conceitos SOLID");

            #region [ SRP ]
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.ChangeName("Nicolas");

            IFornecedorRepository rep = new FornecedorRepository();

            rep.Salvar(fornecedor);
            #endregion

            #region [ OCP ]
            var p = new Pessoa("Joao");
            p.ChangeName("Andre");

            var pf = new PessoaFisica("Andre", "999.999.999-99");
            #endregion
        
            #region  [ LSP ]
            var veiculo = new Carro();
            #endregion
        }
    }
}
