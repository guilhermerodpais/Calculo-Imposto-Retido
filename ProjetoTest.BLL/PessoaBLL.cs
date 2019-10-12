using ProjetoTest.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTest.BLL
{
    public class PessoaBLL
    {

        //TODO:
        public bool PossuiDoencaGrave(Pessoa pessoa)
        {
            string enfermidade = (pessoa.TipoEnfermidade).ToString();
            if (enfermidade != "Inexistente")
            {
                return true;
            }
            return false;
        }

        public bool PossuiTipoIsento(Pessoa pessoa)
        {
            string tipo = (pessoa.TipoRenda).ToString();
            if (tipo != "Salario")
            {
                return true;
            }
            return false;
        }

        //TODO:
        public Pessoa ObterPessoa(string cpf)
        {
            var pessoas = new PessoaDAL().ListarPessoas();

            foreach (var item in pessoas)
            {
                if (item.Cpf == cpf)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
