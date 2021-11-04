using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCamadasPOO.Code.DTO;
using ProjetoCamadasPOO.Code.DAL;

namespace ProjetoCamadasPOO.Code.BLL
{
    class HortaBLL
    {

        AcessoBD conexao = new AcessoBD();
        string tabela = "";





        public void Inserir(HortaDTO hortaDTO)
        {
            string inserir = $"insert into {tabela} values (null, '{hortaDTO.Plantanome}', '{hortaDTO.Preco}', '{hortaDTO.Quantidade}')";
            conexao.ExecutarComando(inserir);

        }

        public void Editar(HortaDTO hortaDTO) 
        {

        }

        public void Exclui(HortaDTO hortaDTO) 
        {
            
        }

        public void Listar()
        {

        }

    }
}
