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

        public void LimparTxt()
        {
            txt_id.Clear();
            txt_nomePlanta.Clear();
            txt_preco.Clear();
            txt_quantidade.Clear();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            hortaDTO.Plantanome = txt_nomePlanta.Text;
            hortaDTO.Preco = double.Parse(txt_preco.Text);
            hortaDTO.Quantidade = int.Parse(txt_quantidade.Text);

            hortaBLL.Inserir(hortaDTO);

            MessageBox.Show("Cadastro feito com sucesso!","HORTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparTxt();

            // To do: Atualizar Data grid, falta metodo listar
           
        }

        private void Frm_HortaShop_Load(object sender, EventArgs e)
        {
            dtg_horta.DataSource = hortaBLL.Listar();
            dtg_horta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_horta.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void dtg_horta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dtg_horta.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nomePlanta.Text = dtg_horta.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_preco.Text = dtg_horta.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_quantidade.Text = dtg_horta.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            hortaDTO.Id = int.Parse(txt_id.Text);
            hortaDTO.Plantanome = txt_nomePlanta.Text;
            hortaDTO.Preco = double.Parse(txt_preco.Text);
            hortaDTO.Quantidade = int.Parse(txt_quantidade.Text);

            hortaBLL.Editar(hortaDTO);

            MessageBox.Show("Alterado!", "HORTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            hortaBLL.Listar();

            LimparTxt();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            hortaDTO.Id = int.Parse(txt_id.Text);

            hortaBLL.Exclui(hortaDTO);

            MessageBox.Show("Excluido!", "HORTA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            hortaBLL.Listar();
        }
    }
}
