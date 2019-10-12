using ProjetoTest;
using ProjetoTest.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTest.BLL
{
    public class ImpostoRendaBLL
    {
        //TODO:
        public decimal ObterImpostoDeRendaRetido(Pessoa pessoa)
        {
            var listaPessoa = new PessoaBLL();
            bool temEnfermidade = listaPessoa.PossuiDoencaGrave(pessoa);
            bool temTipoIsento = listaPessoa.PossuiTipoIsento(pessoa);
            decimal salario = pessoa.TotalRenda;

            decimal valorBase = (decimal)(1903.88);
            decimal valorBase1 = (decimal)(2826.65);
            decimal valorBase2 = (decimal)(3751.05);
            decimal valorBase3 = (decimal)(4664.68);

            if (!temEnfermidade && !temTipoIsento && (salario > valorBase))
            {
                decimal aliquota = 0;

                if (salario > valorBase && salario <= valorBase1)
                {
                    aliquota = (decimal)(0.075);
                }
                else if (salario > valorBase1 && salario <= valorBase2)
                {
                    aliquota = (decimal)(0.15);
                }
                else if (salario > valorBase2 && salario <= valorBase3)
                {
                    aliquota = (decimal)(0.225);
                }
                else
                {
                    aliquota = (decimal)(0.275);
                }

                return salario * aliquota;
            }
            else
            {
                Console.WriteLine(string.Format("Este Cpf é isento."));
            }

            return 0;
        }
    }
}
