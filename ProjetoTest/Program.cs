using ProjetoTest.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"----- SISTEMA IMPOSTO DE RENDA RETIDO -----\n");
            string[] listaPesquisada = new string[] { "05834969038", "47700375038", "58208236055", "42246773008", "31793124086" };

            try
            {
                var listaPessoa = new PessoaBLL();
                var impostoDeRenda = new ImpostoRendaBLL();

                foreach (var cpf in listaPesquisada)
                {
                    var pessoa = listaPessoa.ObterPessoa(cpf);
                    decimal totalImposto = impostoDeRenda.ObterImpostoDeRendaRetido(pessoa);

                    Console.WriteLine(string.Format("Pessoa com cpf - {0} tem retido um total de R$ {1} devido ao imposto de renda.", pessoa.Cpf, totalImposto));
                    Console.WriteLine("----------------------------------------------------------------------------------------------\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Execução foi abortada pelo erro : {ex.Message}");
            }

            Console.WriteLine($"\n----- FIM DO SISTEMA -----");
            System.Console.ReadKey();

        }
    }
}
