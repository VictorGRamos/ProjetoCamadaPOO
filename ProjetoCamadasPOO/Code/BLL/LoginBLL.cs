using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoCamadasPOO.Code.DAL;
using ProjetoCamadasPOO.Code.DTO;
using System.Data;


namespace ProjetoCamadasPOO.Code.BLL
{
    class LoginBLL
    {
        AcessoBD conexao = new AcessoBD();
        string tabela = "tbl_usuario";

        public bool RealizarLogin(LoginDTO login)
        {
            string sql = $"select * from {tabela} where email = '{login.Email}' and senha = '{login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

    }
}
