using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoCamadasPOO.Code.BLL;
using ProjetoCamadasPOO.Code.DTO;

namespace ProjetoCamadasPOO.Ui
{
    public partial class FrmLogin : Form
    {

        LoginDTO loginDTO = new LoginDTO();
        LoginBLL loginBLL = new LoginBLL();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txt_email.Text;
            loginDTO.Senha = txt_senha.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                Frm_HortaShop frm_HortaShop = new Frm_HortaShop();
                frm_HortaShop.ShowDialog();

            }
            else 
            {
                MessageBox.Show("Verifique E-mail e senha", "ERRO", MessageBoxButtons.OK);
            }
        }
    }
}
