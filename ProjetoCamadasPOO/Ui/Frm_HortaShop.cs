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


namespace ProjetoCamadasPOO
{
    public partial class Frm_HortaShop : Form
    {

        HortaBLL hortaBLL = new HortaBLL();
        HortaDTO hortaDTO = new HortaDTO();

        public Frm_HortaShop()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            hortaDTO.Plantanome = txt_nomePlanta.Text;
            hortaDTO.Preco = double.Parse(txt_preco.Text);
            hortaDTO.Quantidade = int.Parse(txt_quantidade.Text);

            //TODO: Falta conexão
           
        }
    }
}
