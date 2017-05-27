using CompCenter_1._0;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp_Center_1._0
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void arterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProdutosAlterar OutraForm = new FormProdutosAlterar();
            OutraForm.ShowDialog();
        }

        private void btnRelatoriosProduto_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnProdutosCadastrar_Click(object sender, EventArgs e)
        {
            FormProdutosCadastrar OutraForm = new FormProdutosCadastrar();
            OutraForm.ShowDialog();
        }

        private void btnProdutosConsultar_Click(object sender, EventArgs e)
        {
            FormProdutosConsultar OutraForm = new FormProdutosConsultar();
            OutraForm.ShowDialog();
        }

        private void btnProdutosExcluir_Click(object sender, EventArgs e)
        {
            FormProdutosExcluir OutraForm = new FormProdutosExcluir();
            OutraForm.ShowDialog();
        }
    }
}
