namespace Comp_Center_1._0
{
    partial class home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.btnProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProdutosCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProdutosConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProdutosAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProdutosExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFornecedoresCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFornecedoresConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFornecedoresAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFornecedoresExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFornecedoresAtivar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientesCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientesConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientesAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientesExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClientesAtivar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuncionariosCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuncionariosConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuncionariosAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuncionariosExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFuncionariosAtivar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetores = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetoresCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetoresConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetoresAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetoresExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSetoresAtivar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.btnComprasCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnComprasConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnComprasAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnComprasExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransferencias = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransferenciasCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransferenciasConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransferenciasAlterar = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTransferenciasExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelatoriosProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelatoriosClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelatoriosFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.rbtnRelatoriosTransferencias = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelatoriosVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelatoriosGraficoVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProdutos,
            this.btnFornecedores,
            this.btnClientes,
            this.btnFuncionarios,
            this.btnSetores,
            this.btnCompras,
            this.btnTransferencias,
            this.btnRelatorios});
            resources.ApplyResources(this.menu, "menu");
            this.menu.Name = "menu";
            this.menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btnProdutos
            // 
            this.btnProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProdutosCadastrar,
            this.btnProdutosConsultar,
            this.btnProdutosAlterar,
            this.btnProdutosExcluir});
            this.btnProdutos.Name = "btnProdutos";
            resources.ApplyResources(this.btnProdutos, "btnProdutos");
            // 
            // btnProdutosCadastrar
            // 
            this.btnProdutosCadastrar.Name = "btnProdutosCadastrar";
            resources.ApplyResources(this.btnProdutosCadastrar, "btnProdutosCadastrar");
            this.btnProdutosCadastrar.Click += new System.EventHandler(this.btnProdutosCadastrar_Click);
            // 
            // btnProdutosConsultar
            // 
            this.btnProdutosConsultar.Name = "btnProdutosConsultar";
            resources.ApplyResources(this.btnProdutosConsultar, "btnProdutosConsultar");
            this.btnProdutosConsultar.Click += new System.EventHandler(this.btnProdutosConsultar_Click);
            // 
            // btnProdutosAlterar
            // 
            this.btnProdutosAlterar.Name = "btnProdutosAlterar";
            resources.ApplyResources(this.btnProdutosAlterar, "btnProdutosAlterar");
            this.btnProdutosAlterar.Click += new System.EventHandler(this.arterarToolStripMenuItem_Click);
            // 
            // btnProdutosExcluir
            // 
            this.btnProdutosExcluir.Name = "btnProdutosExcluir";
            resources.ApplyResources(this.btnProdutosExcluir, "btnProdutosExcluir");
            this.btnProdutosExcluir.Click += new System.EventHandler(this.btnProdutosExcluir_Click);
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFornecedoresCadastrar,
            this.btnFornecedoresConsultar,
            this.btnFornecedoresAlterar,
            this.btnFornecedoresExcluir,
            this.btnFornecedoresAtivar});
            this.btnFornecedores.Name = "btnFornecedores";
            resources.ApplyResources(this.btnFornecedores, "btnFornecedores");
            // 
            // btnFornecedoresCadastrar
            // 
            this.btnFornecedoresCadastrar.Name = "btnFornecedoresCadastrar";
            resources.ApplyResources(this.btnFornecedoresCadastrar, "btnFornecedoresCadastrar");
            // 
            // btnFornecedoresConsultar
            // 
            this.btnFornecedoresConsultar.Name = "btnFornecedoresConsultar";
            resources.ApplyResources(this.btnFornecedoresConsultar, "btnFornecedoresConsultar");
            // 
            // btnFornecedoresAlterar
            // 
            this.btnFornecedoresAlterar.Name = "btnFornecedoresAlterar";
            resources.ApplyResources(this.btnFornecedoresAlterar, "btnFornecedoresAlterar");
            // 
            // btnFornecedoresExcluir
            // 
            this.btnFornecedoresExcluir.Name = "btnFornecedoresExcluir";
            resources.ApplyResources(this.btnFornecedoresExcluir, "btnFornecedoresExcluir");
            // 
            // btnFornecedoresAtivar
            // 
            this.btnFornecedoresAtivar.Name = "btnFornecedoresAtivar";
            resources.ApplyResources(this.btnFornecedoresAtivar, "btnFornecedoresAtivar");
            // 
            // btnClientes
            // 
            this.btnClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientesCadastrar,
            this.btnClientesConsultar,
            this.btnClientesAlterar,
            this.btnClientesExcluir,
            this.btnClientesAtivar});
            this.btnClientes.Name = "btnClientes";
            resources.ApplyResources(this.btnClientes, "btnClientes");
            // 
            // btnClientesCadastrar
            // 
            this.btnClientesCadastrar.Name = "btnClientesCadastrar";
            resources.ApplyResources(this.btnClientesCadastrar, "btnClientesCadastrar");
            // 
            // btnClientesConsultar
            // 
            this.btnClientesConsultar.Name = "btnClientesConsultar";
            resources.ApplyResources(this.btnClientesConsultar, "btnClientesConsultar");
            // 
            // btnClientesAlterar
            // 
            this.btnClientesAlterar.Name = "btnClientesAlterar";
            resources.ApplyResources(this.btnClientesAlterar, "btnClientesAlterar");
            // 
            // btnClientesExcluir
            // 
            this.btnClientesExcluir.Name = "btnClientesExcluir";
            resources.ApplyResources(this.btnClientesExcluir, "btnClientesExcluir");
            // 
            // btnClientesAtivar
            // 
            this.btnClientesAtivar.Name = "btnClientesAtivar";
            resources.ApplyResources(this.btnClientesAtivar, "btnClientesAtivar");
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFuncionariosCadastrar,
            this.btnFuncionariosConsultar,
            this.btnFuncionariosAlterar,
            this.btnFuncionariosExcluir,
            this.btnFuncionariosAtivar});
            this.btnFuncionarios.Name = "btnFuncionarios";
            resources.ApplyResources(this.btnFuncionarios, "btnFuncionarios");
            // 
            // btnFuncionariosCadastrar
            // 
            this.btnFuncionariosCadastrar.Name = "btnFuncionariosCadastrar";
            resources.ApplyResources(this.btnFuncionariosCadastrar, "btnFuncionariosCadastrar");
            // 
            // btnFuncionariosConsultar
            // 
            this.btnFuncionariosConsultar.Name = "btnFuncionariosConsultar";
            resources.ApplyResources(this.btnFuncionariosConsultar, "btnFuncionariosConsultar");
            // 
            // btnFuncionariosAlterar
            // 
            this.btnFuncionariosAlterar.Name = "btnFuncionariosAlterar";
            resources.ApplyResources(this.btnFuncionariosAlterar, "btnFuncionariosAlterar");
            // 
            // btnFuncionariosExcluir
            // 
            this.btnFuncionariosExcluir.Name = "btnFuncionariosExcluir";
            resources.ApplyResources(this.btnFuncionariosExcluir, "btnFuncionariosExcluir");
            // 
            // btnFuncionariosAtivar
            // 
            this.btnFuncionariosAtivar.Name = "btnFuncionariosAtivar";
            resources.ApplyResources(this.btnFuncionariosAtivar, "btnFuncionariosAtivar");
            // 
            // btnSetores
            // 
            this.btnSetores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSetoresCadastrar,
            this.btnSetoresConsultar,
            this.btnSetoresAlterar,
            this.btnSetoresExcluir,
            this.btnSetoresAtivar});
            this.btnSetores.Name = "btnSetores";
            resources.ApplyResources(this.btnSetores, "btnSetores");
            // 
            // btnSetoresCadastrar
            // 
            this.btnSetoresCadastrar.Name = "btnSetoresCadastrar";
            resources.ApplyResources(this.btnSetoresCadastrar, "btnSetoresCadastrar");
            // 
            // btnSetoresConsultar
            // 
            this.btnSetoresConsultar.Name = "btnSetoresConsultar";
            resources.ApplyResources(this.btnSetoresConsultar, "btnSetoresConsultar");
            // 
            // btnSetoresAlterar
            // 
            this.btnSetoresAlterar.Name = "btnSetoresAlterar";
            resources.ApplyResources(this.btnSetoresAlterar, "btnSetoresAlterar");
            // 
            // btnSetoresExcluir
            // 
            this.btnSetoresExcluir.Name = "btnSetoresExcluir";
            resources.ApplyResources(this.btnSetoresExcluir, "btnSetoresExcluir");
            // 
            // btnSetoresAtivar
            // 
            this.btnSetoresAtivar.Name = "btnSetoresAtivar";
            resources.ApplyResources(this.btnSetoresAtivar, "btnSetoresAtivar");
            // 
            // btnCompras
            // 
            this.btnCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnComprasCadastrar,
            this.btnComprasConsultar,
            this.btnComprasAlterar,
            this.btnComprasExcluir});
            this.btnCompras.Name = "btnCompras";
            resources.ApplyResources(this.btnCompras, "btnCompras");
            // 
            // btnComprasCadastrar
            // 
            this.btnComprasCadastrar.Name = "btnComprasCadastrar";
            resources.ApplyResources(this.btnComprasCadastrar, "btnComprasCadastrar");
            // 
            // btnComprasConsultar
            // 
            this.btnComprasConsultar.Name = "btnComprasConsultar";
            resources.ApplyResources(this.btnComprasConsultar, "btnComprasConsultar");
            // 
            // btnComprasAlterar
            // 
            this.btnComprasAlterar.Name = "btnComprasAlterar";
            resources.ApplyResources(this.btnComprasAlterar, "btnComprasAlterar");
            // 
            // btnComprasExcluir
            // 
            this.btnComprasExcluir.Name = "btnComprasExcluir";
            resources.ApplyResources(this.btnComprasExcluir, "btnComprasExcluir");
            // 
            // btnTransferencias
            // 
            this.btnTransferencias.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnTransferenciasCadastrar,
            this.btnTransferenciasConsultar,
            this.btnTransferenciasAlterar,
            this.btnTransferenciasExcluir});
            this.btnTransferencias.Name = "btnTransferencias";
            resources.ApplyResources(this.btnTransferencias, "btnTransferencias");
            // 
            // btnTransferenciasCadastrar
            // 
            this.btnTransferenciasCadastrar.Name = "btnTransferenciasCadastrar";
            resources.ApplyResources(this.btnTransferenciasCadastrar, "btnTransferenciasCadastrar");
            // 
            // btnTransferenciasConsultar
            // 
            this.btnTransferenciasConsultar.Name = "btnTransferenciasConsultar";
            resources.ApplyResources(this.btnTransferenciasConsultar, "btnTransferenciasConsultar");
            // 
            // btnTransferenciasAlterar
            // 
            this.btnTransferenciasAlterar.Name = "btnTransferenciasAlterar";
            resources.ApplyResources(this.btnTransferenciasAlterar, "btnTransferenciasAlterar");
            // 
            // btnTransferenciasExcluir
            // 
            this.btnTransferenciasExcluir.Name = "btnTransferenciasExcluir";
            resources.ApplyResources(this.btnTransferenciasExcluir, "btnTransferenciasExcluir");
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRelatoriosProdutos,
            this.btnRelatoriosClientes,
            this.btnRelatoriosFuncionarios,
            this.rbtnRelatoriosTransferencias,
            this.btnRelatoriosVendas,
            this.btnRelatoriosGraficoVendas});
            this.btnRelatorios.Name = "btnRelatorios";
            resources.ApplyResources(this.btnRelatorios, "btnRelatorios");
            // 
            // btnRelatoriosProdutos
            // 
            this.btnRelatoriosProdutos.Name = "btnRelatoriosProdutos";
            resources.ApplyResources(this.btnRelatoriosProdutos, "btnRelatoriosProdutos");
            this.btnRelatoriosProdutos.Click += new System.EventHandler(this.btnRelatoriosProduto_Click);
            // 
            // btnRelatoriosClientes
            // 
            this.btnRelatoriosClientes.Name = "btnRelatoriosClientes";
            resources.ApplyResources(this.btnRelatoriosClientes, "btnRelatoriosClientes");
            // 
            // btnRelatoriosFuncionarios
            // 
            this.btnRelatoriosFuncionarios.Name = "btnRelatoriosFuncionarios";
            resources.ApplyResources(this.btnRelatoriosFuncionarios, "btnRelatoriosFuncionarios");
            // 
            // rbtnRelatoriosTransferencias
            // 
            this.rbtnRelatoriosTransferencias.Name = "rbtnRelatoriosTransferencias";
            resources.ApplyResources(this.rbtnRelatoriosTransferencias, "rbtnRelatoriosTransferencias");
            // 
            // btnRelatoriosVendas
            // 
            this.btnRelatoriosVendas.Name = "btnRelatoriosVendas";
            resources.ApplyResources(this.btnRelatoriosVendas, "btnRelatoriosVendas");
            // 
            // btnRelatoriosGraficoVendas
            // 
            this.btnRelatoriosGraficoVendas.Name = "btnRelatoriosGraficoVendas";
            resources.ApplyResources(this.btnRelatoriosGraficoVendas, "btnRelatoriosGraficoVendas");
            // 
            // home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "home";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem btnProdutos;
        private System.Windows.Forms.ToolStripMenuItem btnProdutosCadastrar;
        private System.Windows.Forms.ToolStripMenuItem btnProdutosConsultar;
        private System.Windows.Forms.ToolStripMenuItem btnProdutosAlterar;
        private System.Windows.Forms.ToolStripMenuItem btnProdutosExcluir;
        private System.Windows.Forms.ToolStripMenuItem btnFornecedores;
        private System.Windows.Forms.ToolStripMenuItem btnFornecedoresCadastrar;
        private System.Windows.Forms.ToolStripMenuItem btnFornecedoresConsultar;
        private System.Windows.Forms.ToolStripMenuItem btnFornecedoresAlterar;
        private System.Windows.Forms.ToolStripMenuItem btnFornecedoresExcluir;
        private System.Windows.Forms.ToolStripMenuItem btnFornecedoresAtivar;
        private System.Windows.Forms.ToolStripMenuItem btnClientes;
        private System.Windows.Forms.ToolStripMenuItem btnClientesCadastrar;
        private System.Windows.Forms.ToolStripMenuItem btnClientesConsultar;
        private System.Windows.Forms.ToolStripMenuItem btnClientesAlterar;
        private System.Windows.Forms.ToolStripMenuItem btnClientesExcluir;
        private System.Windows.Forms.ToolStripMenuItem btnClientesAtivar;
        private System.Windows.Forms.ToolStripMenuItem btnFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem btnFuncionariosCadastrar;
        private System.Windows.Forms.ToolStripMenuItem btnFuncionariosConsultar;
        private System.Windows.Forms.ToolStripMenuItem btnFuncionariosAlterar;
        private System.Windows.Forms.ToolStripMenuItem btnFuncionariosExcluir;
        private System.Windows.Forms.ToolStripMenuItem btnFuncionariosAtivar;
        private System.Windows.Forms.ToolStripMenuItem btnSetores;
        private System.Windows.Forms.ToolStripMenuItem btnSetoresCadastrar;
        private System.Windows.Forms.ToolStripMenuItem btnSetoresConsultar;
        private System.Windows.Forms.ToolStripMenuItem btnSetoresAlterar;
        private System.Windows.Forms.ToolStripMenuItem btnSetoresExcluir;
        private System.Windows.Forms.ToolStripMenuItem btnSetoresAtivar;
        private System.Windows.Forms.ToolStripMenuItem btnCompras;
        private System.Windows.Forms.ToolStripMenuItem btnComprasCadastrar;
        private System.Windows.Forms.ToolStripMenuItem btnComprasConsultar;
        private System.Windows.Forms.ToolStripMenuItem btnComprasAlterar;
        private System.Windows.Forms.ToolStripMenuItem btnComprasExcluir;
        private System.Windows.Forms.ToolStripMenuItem btnTransferencias;
        private System.Windows.Forms.ToolStripMenuItem btnTransferenciasCadastrar;
        private System.Windows.Forms.ToolStripMenuItem btnTransferenciasConsultar;
        private System.Windows.Forms.ToolStripMenuItem btnTransferenciasAlterar;
        private System.Windows.Forms.ToolStripMenuItem btnTransferenciasExcluir;
        private System.Windows.Forms.ToolStripMenuItem btnRelatorios;
        private System.Windows.Forms.ToolStripMenuItem btnRelatoriosProdutos;
        private System.Windows.Forms.ToolStripMenuItem btnRelatoriosClientes;
        private System.Windows.Forms.ToolStripMenuItem btnRelatoriosFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem rbtnRelatoriosTransferencias;
        private System.Windows.Forms.ToolStripMenuItem btnRelatoriosVendas;
        private System.Windows.Forms.ToolStripMenuItem btnRelatoriosGraficoVendas;
    }
}

