using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompCenter_1._0
{
    public partial class FormProdutosExcluir : System.Windows.Forms.Form
    {
        public FormProdutosExcluir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult OpcaoDoUsuario = new DialogResult();
            OpcaoDoUsuario = MessageBox.Show("Tem Certeza Que Deseja Excluir Os Itens Selecionados?", "Atencao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (OpcaoDoUsuario == DialogResult.Yes)
            {
                MessageBox.Show("Excluido Com Sucesso!","Atencao", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
           
        }
    }
}
