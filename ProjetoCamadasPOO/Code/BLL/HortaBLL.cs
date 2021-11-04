using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCamadasPOO.Code.DTO;
using ProjetoCamadasPOO.Code.DAL;
using System.Data;

namespace ProjetoCamadasPOO.Code.BLL
{
    class HortaBLL
    {

        AcessoBD conexao = new AcessoBD();
        string tabela = "tbl_estoque";





        public void Inserir(HortaDTO hortaDTO)
        {
            string inserir = $"insert into {tabela} values (null, '{hortaDTO.Plantanome}', '{hortaDTO.Preco}', '{hortaDTO.Quantidade}')";
            conexao.ExecutarComando(inserir);

        }

        public void Editar(HortaDTO hortaDTO) 
        {
            string alterar = $"update {tabela} set nome_planta = '{hortaDTO.Plantanome}', preco_item = '{hortaDTO.Preco}'," +
                $"qnt_estoque = '{hortaDTO.Quantidade}' where id = '{hortaDTO.Id}'";
            conexao.ExecutarComando(alterar);
        }

        public void Exclui(HortaDTO hortaDTO) 
        {
            string excluir = $"delete from {tabela} where id = '{hortaDTO.Id}';";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

    }
}
