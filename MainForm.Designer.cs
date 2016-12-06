namespace TemplateTool
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBemVindo = new System.Windows.Forms.TabPage();
            this.richTextBoxBemVindo = new System.Windows.Forms.RichTextBox();
            this.tabPageSelecaoProjetos = new System.Windows.Forms.TabPage();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.labelProjetos = new System.Windows.Forms.Label();
            this.listViewProjetos = new System.Windows.Forms.ListView();
            this.columnHeaderCollection = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProjeto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewCollections = new System.Windows.Forms.ListView();
            this.columnNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelListaCollections = new System.Windows.Forms.Label();
            this.buttonConectar = new System.Windows.Forms.Button();
            this.tabPageConfiguracao = new System.Windows.Forms.TabPage();
            this.groupBoxEdicao = new System.Windows.Forms.GroupBox();
            this.buttonRemoverPropriedade = new System.Windows.Forms.Button();
            this.buttonSalvarPropriedade = new System.Windows.Forms.Button();
            this.buttonCancelarPropriedade = new System.Windows.Forms.Button();
            this.buttonAdicionarPropriedade = new System.Windows.Forms.Button();
            this.labelValorPropriedade = new System.Windows.Forms.Label();
            this.labelNomePropriedade = new System.Windows.Forms.Label();
            this.textBoxNomePropriedade = new System.Windows.Forms.TextBox();
            this.labelDicaEdicao = new System.Windows.Forms.Label();
            this.textBoxValorPropriedade = new System.Windows.Forms.TextBox();
            this.labelListaDeParametros = new System.Windows.Forms.Label();
            this.listViewParametros = new System.Windows.Forms.ListView();
            this.columnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageTemplates = new System.Windows.Forms.TabPage();
            this.labelSelecioneTiposDeTemplateImportar = new System.Windows.Forms.Label();
            this.checkedListBoxTiposDeTemplate = new System.Windows.Forms.CheckedListBox();
            this.tabPageConfirmacao = new System.Windows.Forms.TabPage();
            this.checkBoxConfirmarExecução = new System.Windows.Forms.CheckBox();
            this.textBoxConfirmacaoDeComandos = new System.Windows.Forms.TextBox();
            this.labelConfirmacaoDeExecucaoDeComandos = new System.Windows.Forms.Label();
            this.tabPageProcessamento = new System.Windows.Forms.TabPage();
            this.labelSaida = new System.Windows.Forms.Label();
            this.textBoxSaida = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonProximo = new System.Windows.Forms.Button();
            this.buttonAnterior = new System.Windows.Forms.Button();
            this.buttonSair = new System.Windows.Forms.Button();
            this.pictureBoxTitulo = new System.Windows.Forms.PictureBox();
            this.labelVersao = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageBemVindo.SuspendLayout();
            this.tabPageSelecaoProjetos.SuspendLayout();
            this.tabPageConfiguracao.SuspendLayout();
            this.groupBoxEdicao.SuspendLayout();
            this.tabPageTemplates.SuspendLayout();
            this.tabPageConfirmacao.SuspendLayout();
            this.tabPageProcessamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageBemVindo);
            this.tabControl1.Controls.Add(this.tabPageSelecaoProjetos);
            this.tabControl1.Controls.Add(this.tabPageTemplates);
            this.tabControl1.Controls.Add(this.tabPageConfiguracao);
            this.tabControl1.Controls.Add(this.tabPageConfirmacao);
            this.tabControl1.Controls.Add(this.tabPageProcessamento);
            this.tabControl1.Location = new System.Drawing.Point(12, 123);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 386);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.TabStop = false;
            // 
            // tabPageBemVindo
            // 
            this.tabPageBemVindo.Controls.Add(this.richTextBoxBemVindo);
            this.tabPageBemVindo.Location = new System.Drawing.Point(4, 22);
            this.tabPageBemVindo.Name = "tabPageBemVindo";
            this.tabPageBemVindo.Size = new System.Drawing.Size(702, 360);
            this.tabPageBemVindo.TabIndex = 5;
            this.tabPageBemVindo.Text = "Bem Vindo";
            this.tabPageBemVindo.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBemVindo
            // 
            this.richTextBoxBemVindo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxBemVindo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxBemVindo.Location = new System.Drawing.Point(20, 19);
            this.richTextBoxBemVindo.Name = "richTextBoxBemVindo";
            this.richTextBoxBemVindo.ReadOnly = true;
            this.richTextBoxBemVindo.Size = new System.Drawing.Size(656, 314);
            this.richTextBoxBemVindo.TabIndex = 1;
            this.richTextBoxBemVindo.Text = "";
            // 
            // tabPageSelecaoProjetos
            // 
            this.tabPageSelecaoProjetos.Controls.Add(this.textBoxUrl);
            this.tabPageSelecaoProjetos.Controls.Add(this.labelUrl);
            this.tabPageSelecaoProjetos.Controls.Add(this.labelProjetos);
            this.tabPageSelecaoProjetos.Controls.Add(this.listViewProjetos);
            this.tabPageSelecaoProjetos.Controls.Add(this.listViewCollections);
            this.tabPageSelecaoProjetos.Controls.Add(this.labelListaCollections);
            this.tabPageSelecaoProjetos.Controls.Add(this.buttonConectar);
            this.tabPageSelecaoProjetos.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelecaoProjetos.Name = "tabPageSelecaoProjetos";
            this.tabPageSelecaoProjetos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelecaoProjetos.Size = new System.Drawing.Size(702, 360);
            this.tabPageSelecaoProjetos.TabIndex = 0;
            this.tabPageSelecaoProjetos.Text = "Seleção de Projetos";
            this.tabPageSelecaoProjetos.UseVisualStyleBackColor = true;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxUrl.Location = new System.Drawing.Point(9, 25);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(583, 20);
            this.textBoxUrl.TabIndex = 6;
            this.textBoxUrl.Text = "http://gbjndsrv014:8080/tfs";
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(6, 9);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(91, 13);
            this.labelUrl.TabIndex = 5;
            this.labelUrl.Text = "Endereço do TFS";
            // 
            // labelProjetos
            // 
            this.labelProjetos.AutoSize = true;
            this.labelProjetos.Location = new System.Drawing.Point(238, 48);
            this.labelProjetos.Name = "labelProjetos";
            this.labelProjetos.Size = new System.Drawing.Size(45, 13);
            this.labelProjetos.TabIndex = 4;
            this.labelProjetos.Text = "Projetos";
            // 
            // listViewProjetos
            // 
            this.listViewProjetos.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewProjetos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProjetos.CheckBoxes = true;
            this.listViewProjetos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCollection,
            this.columnHeaderProjeto});
            this.listViewProjetos.FullRowSelect = true;
            this.listViewProjetos.GridLines = true;
            this.listViewProjetos.Location = new System.Drawing.Point(241, 64);
            this.listViewProjetos.Name = "listViewProjetos";
            this.listViewProjetos.Size = new System.Drawing.Size(450, 290);
            this.listViewProjetos.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewProjetos.TabIndex = 3;
            this.listViewProjetos.UseCompatibleStateImageBehavior = false;
            this.listViewProjetos.View = System.Windows.Forms.View.Details;
            this.listViewProjetos.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewProjetos_ItemChecked);
            // 
            // columnHeaderCollection
            // 
            this.columnHeaderCollection.Text = "Collection";
            this.columnHeaderCollection.Width = 150;
            // 
            // columnHeaderProjeto
            // 
            this.columnHeaderProjeto.Text = "Projeto";
            this.columnHeaderProjeto.Width = 250;
            // 
            // listViewCollections
            // 
            this.listViewCollections.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewCollections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewCollections.CheckBoxes = true;
            this.listViewCollections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNome});
            this.listViewCollections.FullRowSelect = true;
            this.listViewCollections.GridLines = true;
            this.listViewCollections.Location = new System.Drawing.Point(9, 64);
            this.listViewCollections.Name = "listViewCollections";
            this.listViewCollections.Size = new System.Drawing.Size(220, 290);
            this.listViewCollections.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewCollections.TabIndex = 2;
            this.listViewCollections.UseCompatibleStateImageBehavior = false;
            this.listViewCollections.View = System.Windows.Forms.View.Details;
            this.listViewCollections.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listViewCollections_ItemChecked);
            // 
            // columnNome
            // 
            this.columnNome.Text = "Nome";
            this.columnNome.Width = 200;
            // 
            // labelListaCollections
            // 
            this.labelListaCollections.AutoSize = true;
            this.labelListaCollections.Location = new System.Drawing.Point(6, 48);
            this.labelListaCollections.Name = "labelListaCollections";
            this.labelListaCollections.Size = new System.Drawing.Size(58, 13);
            this.labelListaCollections.TabIndex = 1;
            this.labelListaCollections.Text = "Collections";
            // 
            // buttonConectar
            // 
            this.buttonConectar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonConectar.Location = new System.Drawing.Point(598, 9);
            this.buttonConectar.Name = "buttonConectar";
            this.buttonConectar.Size = new System.Drawing.Size(93, 36);
            this.buttonConectar.TabIndex = 0;
            this.buttonConectar.Text = "Conectar";
            this.buttonConectar.UseVisualStyleBackColor = true;
            this.buttonConectar.Click += new System.EventHandler(this.buttonConectar_Click);
            // 
            // tabPageConfiguracao
            // 
            this.tabPageConfiguracao.Controls.Add(this.groupBoxEdicao);
            this.tabPageConfiguracao.Controls.Add(this.labelListaDeParametros);
            this.tabPageConfiguracao.Controls.Add(this.listViewParametros);
            this.tabPageConfiguracao.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguracao.Name = "tabPageConfiguracao";
            this.tabPageConfiguracao.Size = new System.Drawing.Size(702, 360);
            this.tabPageConfiguracao.TabIndex = 4;
            this.tabPageConfiguracao.Text = "Configuração";
            this.tabPageConfiguracao.UseVisualStyleBackColor = true;
            // 
            // groupBoxEdicao
            // 
            this.groupBoxEdicao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxEdicao.Controls.Add(this.buttonRemoverPropriedade);
            this.groupBoxEdicao.Controls.Add(this.buttonSalvarPropriedade);
            this.groupBoxEdicao.Controls.Add(this.buttonCancelarPropriedade);
            this.groupBoxEdicao.Controls.Add(this.buttonAdicionarPropriedade);
            this.groupBoxEdicao.Controls.Add(this.labelValorPropriedade);
            this.groupBoxEdicao.Controls.Add(this.labelNomePropriedade);
            this.groupBoxEdicao.Controls.Add(this.textBoxNomePropriedade);
            this.groupBoxEdicao.Controls.Add(this.labelDicaEdicao);
            this.groupBoxEdicao.Controls.Add(this.textBoxValorPropriedade);
            this.groupBoxEdicao.Location = new System.Drawing.Point(9, 190);
            this.groupBoxEdicao.Name = "groupBoxEdicao";
            this.groupBoxEdicao.Size = new System.Drawing.Size(682, 160);
            this.groupBoxEdicao.TabIndex = 2;
            this.groupBoxEdicao.TabStop = false;
            this.groupBoxEdicao.Text = "Edição";
            // 
            // buttonRemoverPropriedade
            // 
            this.buttonRemoverPropriedade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoverPropriedade.Location = new System.Drawing.Point(608, 81);
            this.buttonRemoverPropriedade.Name = "buttonRemoverPropriedade";
            this.buttonRemoverPropriedade.Size = new System.Drawing.Size(68, 29);
            this.buttonRemoverPropriedade.TabIndex = 10;
            this.buttonRemoverPropriedade.Text = "&Remover";
            this.buttonRemoverPropriedade.UseVisualStyleBackColor = true;
            this.buttonRemoverPropriedade.Click += new System.EventHandler(this.buttonRemoverPropriedade_Click);
            // 
            // buttonSalvarPropriedade
            // 
            this.buttonSalvarPropriedade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalvarPropriedade.Location = new System.Drawing.Point(608, 46);
            this.buttonSalvarPropriedade.Name = "buttonSalvarPropriedade";
            this.buttonSalvarPropriedade.Size = new System.Drawing.Size(68, 29);
            this.buttonSalvarPropriedade.TabIndex = 9;
            this.buttonSalvarPropriedade.Text = "&Salvar";
            this.buttonSalvarPropriedade.UseVisualStyleBackColor = true;
            this.buttonSalvarPropriedade.Click += new System.EventHandler(this.buttonSalvarPropriedade_Click);
            // 
            // buttonCancelarPropriedade
            // 
            this.buttonCancelarPropriedade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelarPropriedade.Location = new System.Drawing.Point(608, 12);
            this.buttonCancelarPropriedade.Name = "buttonCancelarPropriedade";
            this.buttonCancelarPropriedade.Size = new System.Drawing.Size(68, 29);
            this.buttonCancelarPropriedade.TabIndex = 8;
            this.buttonCancelarPropriedade.Text = "&Cancelar";
            this.buttonCancelarPropriedade.UseVisualStyleBackColor = true;
            this.buttonCancelarPropriedade.Click += new System.EventHandler(this.buttonCancelarPropriedade_Click);
            // 
            // buttonAdicionarPropriedade
            // 
            this.buttonAdicionarPropriedade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdicionarPropriedade.Location = new System.Drawing.Point(608, 116);
            this.buttonAdicionarPropriedade.Name = "buttonAdicionarPropriedade";
            this.buttonAdicionarPropriedade.Size = new System.Drawing.Size(68, 29);
            this.buttonAdicionarPropriedade.TabIndex = 11;
            this.buttonAdicionarPropriedade.Text = "A&dicionar";
            this.buttonAdicionarPropriedade.UseVisualStyleBackColor = true;
            this.buttonAdicionarPropriedade.Click += new System.EventHandler(this.buttonAdicionarPropriedade_Click);
            // 
            // labelValorPropriedade
            // 
            this.labelValorPropriedade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValorPropriedade.AutoSize = true;
            this.labelValorPropriedade.Location = new System.Drawing.Point(6, 125);
            this.labelValorPropriedade.Name = "labelValorPropriedade";
            this.labelValorPropriedade.Size = new System.Drawing.Size(31, 13);
            this.labelValorPropriedade.TabIndex = 8;
            this.labelValorPropriedade.Text = "Valor";
            // 
            // labelNomePropriedade
            // 
            this.labelNomePropriedade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelNomePropriedade.AutoSize = true;
            this.labelNomePropriedade.Location = new System.Drawing.Point(6, 99);
            this.labelNomePropriedade.Name = "labelNomePropriedade";
            this.labelNomePropriedade.Size = new System.Drawing.Size(35, 13);
            this.labelNomePropriedade.TabIndex = 7;
            this.labelNomePropriedade.Text = "Nome";
            // 
            // textBoxNomePropriedade
            // 
            this.textBoxNomePropriedade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNomePropriedade.Location = new System.Drawing.Point(51, 99);
            this.textBoxNomePropriedade.Name = "textBoxNomePropriedade";
            this.textBoxNomePropriedade.Size = new System.Drawing.Size(551, 20);
            this.textBoxNomePropriedade.TabIndex = 6;
            // 
            // labelDicaEdicao
            // 
            this.labelDicaEdicao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDicaEdicao.Location = new System.Drawing.Point(18, 27);
            this.labelDicaEdicao.Name = "labelDicaEdicao";
            this.labelDicaEdicao.Size = new System.Drawing.Size(647, 69);
            this.labelDicaEdicao.TabIndex = 5;
            this.labelDicaEdicao.Text = resources.GetString("labelDicaEdicao.Text");
            // 
            // textBoxValorPropriedade
            // 
            this.textBoxValorPropriedade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxValorPropriedade.Location = new System.Drawing.Point(51, 125);
            this.textBoxValorPropriedade.Name = "textBoxValorPropriedade";
            this.textBoxValorPropriedade.Size = new System.Drawing.Size(551, 20);
            this.textBoxValorPropriedade.TabIndex = 7;
            // 
            // labelListaDeParametros
            // 
            this.labelListaDeParametros.AutoSize = true;
            this.labelListaDeParametros.Location = new System.Drawing.Point(6, 9);
            this.labelListaDeParametros.Name = "labelListaDeParametros";
            this.labelListaDeParametros.Size = new System.Drawing.Size(99, 13);
            this.labelListaDeParametros.TabIndex = 1;
            this.labelListaDeParametros.Text = "Lista de parâmetros";
            // 
            // listViewParametros
            // 
            this.listViewParametros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewParametros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNome,
            this.columnHeaderValor});
            this.listViewParametros.FullRowSelect = true;
            this.listViewParametros.GridLines = true;
            this.listViewParametros.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewParametros.HideSelection = false;
            this.listViewParametros.Location = new System.Drawing.Point(9, 25);
            this.listViewParametros.MultiSelect = false;
            this.listViewParametros.Name = "listViewParametros";
            this.listViewParametros.Size = new System.Drawing.Size(682, 159);
            this.listViewParametros.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listViewParametros.TabIndex = 0;
            this.listViewParametros.UseCompatibleStateImageBehavior = false;
            this.listViewParametros.View = System.Windows.Forms.View.Details;
            this.listViewParametros.SelectedIndexChanged += new System.EventHandler(this.listViewParametros_SelectedIndexChanged);
            this.listViewParametros.DoubleClick += new System.EventHandler(this.listViewParametros_DoubleClick);
            this.listViewParametros.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewParametros_KeyUp);
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 300;
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor";
            this.columnHeaderValor.Width = 300;
            // 
            // tabPageTemplates
            // 
            this.tabPageTemplates.Controls.Add(this.labelSelecioneTiposDeTemplateImportar);
            this.tabPageTemplates.Controls.Add(this.checkedListBoxTiposDeTemplate);
            this.tabPageTemplates.Location = new System.Drawing.Point(4, 22);
            this.tabPageTemplates.Name = "tabPageTemplates";
            this.tabPageTemplates.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTemplates.Size = new System.Drawing.Size(702, 360);
            this.tabPageTemplates.TabIndex = 1;
            this.tabPageTemplates.Text = "Templates";
            this.tabPageTemplates.UseVisualStyleBackColor = true;
            // 
            // labelSelecioneTiposDeTemplateImportar
            // 
            this.labelSelecioneTiposDeTemplateImportar.AutoSize = true;
            this.labelSelecioneTiposDeTemplateImportar.Location = new System.Drawing.Point(6, 9);
            this.labelSelecioneTiposDeTemplateImportar.Name = "labelSelecioneTiposDeTemplateImportar";
            this.labelSelecioneTiposDeTemplateImportar.Size = new System.Drawing.Size(215, 13);
            this.labelSelecioneTiposDeTemplateImportar.TabIndex = 2;
            this.labelSelecioneTiposDeTemplateImportar.Text = "Selecione os tipos de template para importar";
            // 
            // checkedListBoxTiposDeTemplate
            // 
            this.checkedListBoxTiposDeTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxTiposDeTemplate.CheckOnClick = true;
            this.checkedListBoxTiposDeTemplate.FormattingEnabled = true;
            this.checkedListBoxTiposDeTemplate.Location = new System.Drawing.Point(6, 36);
            this.checkedListBoxTiposDeTemplate.Name = "checkedListBoxTiposDeTemplate";
            this.checkedListBoxTiposDeTemplate.Size = new System.Drawing.Size(686, 304);
            this.checkedListBoxTiposDeTemplate.TabIndex = 1;
            this.checkedListBoxTiposDeTemplate.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxTiposDeTemplate_ItemCheck);
            // 
            // tabPageConfirmacao
            // 
            this.tabPageConfirmacao.Controls.Add(this.checkBoxConfirmarExecução);
            this.tabPageConfirmacao.Controls.Add(this.textBoxConfirmacaoDeComandos);
            this.tabPageConfirmacao.Controls.Add(this.labelConfirmacaoDeExecucaoDeComandos);
            this.tabPageConfirmacao.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfirmacao.Name = "tabPageConfirmacao";
            this.tabPageConfirmacao.Size = new System.Drawing.Size(702, 360);
            this.tabPageConfirmacao.TabIndex = 2;
            this.tabPageConfirmacao.Text = "Confirmação";
            this.tabPageConfirmacao.UseVisualStyleBackColor = true;
            // 
            // checkBoxConfirmarExecução
            // 
            this.checkBoxConfirmarExecução.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxConfirmarExecução.AutoSize = true;
            this.checkBoxConfirmarExecução.Location = new System.Drawing.Point(7, 340);
            this.checkBoxConfirmarExecução.Name = "checkBoxConfirmarExecução";
            this.checkBoxConfirmarExecução.Size = new System.Drawing.Size(129, 17);
            this.checkBoxConfirmarExecução.TabIndex = 2;
            this.checkBoxConfirmarExecução.Text = "&Confirmar a execução";
            this.checkBoxConfirmarExecução.UseVisualStyleBackColor = true;
            this.checkBoxConfirmarExecução.CheckedChanged += new System.EventHandler(this.checkBoxConfirmarExecução_CheckedChanged);
            // 
            // textBoxConfirmacaoDeComandos
            // 
            this.textBoxConfirmacaoDeComandos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxConfirmacaoDeComandos.HideSelection = false;
            this.textBoxConfirmacaoDeComandos.Location = new System.Drawing.Point(7, 21);
            this.textBoxConfirmacaoDeComandos.Multiline = true;
            this.textBoxConfirmacaoDeComandos.Name = "textBoxConfirmacaoDeComandos";
            this.textBoxConfirmacaoDeComandos.ReadOnly = true;
            this.textBoxConfirmacaoDeComandos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxConfirmacaoDeComandos.Size = new System.Drawing.Size(686, 313);
            this.textBoxConfirmacaoDeComandos.TabIndex = 1;
            this.textBoxConfirmacaoDeComandos.WordWrap = false;
            // 
            // labelConfirmacaoDeExecucaoDeComandos
            // 
            this.labelConfirmacaoDeExecucaoDeComandos.AutoSize = true;
            this.labelConfirmacaoDeExecucaoDeComandos.Location = new System.Drawing.Point(4, 4);
            this.labelConfirmacaoDeExecucaoDeComandos.Name = "labelConfirmacaoDeExecucaoDeComandos";
            this.labelConfirmacaoDeExecucaoDeComandos.Size = new System.Drawing.Size(222, 13);
            this.labelConfirmacaoDeExecucaoDeComandos.TabIndex = 0;
            this.labelConfirmacaoDeExecucaoDeComandos.Text = "Confirme a execução dos comandos a seguir:";
            // 
            // tabPageProcessamento
            // 
            this.tabPageProcessamento.Controls.Add(this.labelSaida);
            this.tabPageProcessamento.Controls.Add(this.textBoxSaida);
            this.tabPageProcessamento.Controls.Add(this.progressBar1);
            this.tabPageProcessamento.Location = new System.Drawing.Point(4, 22);
            this.tabPageProcessamento.Name = "tabPageProcessamento";
            this.tabPageProcessamento.Size = new System.Drawing.Size(702, 360);
            this.tabPageProcessamento.TabIndex = 3;
            this.tabPageProcessamento.Text = "Processamento";
            this.tabPageProcessamento.UseVisualStyleBackColor = true;
            // 
            // labelSaida
            // 
            this.labelSaida.AutoSize = true;
            this.labelSaida.Location = new System.Drawing.Point(4, 4);
            this.labelSaida.Name = "labelSaida";
            this.labelSaida.Size = new System.Drawing.Size(36, 13);
            this.labelSaida.TabIndex = 2;
            this.labelSaida.Text = "Saída";
            // 
            // textBoxSaida
            // 
            this.textBoxSaida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSaida.Location = new System.Drawing.Point(8, 23);
            this.textBoxSaida.Multiline = true;
            this.textBoxSaida.Name = "textBoxSaida";
            this.textBoxSaida.ReadOnly = true;
            this.textBoxSaida.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSaida.Size = new System.Drawing.Size(681, 296);
            this.textBoxSaida.TabIndex = 1;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(8, 329);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(681, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // buttonProximo
            // 
            this.buttonProximo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProximo.Location = new System.Drawing.Point(619, 515);
            this.buttonProximo.Name = "buttonProximo";
            this.buttonProximo.Size = new System.Drawing.Size(99, 25);
            this.buttonProximo.TabIndex = 3;
            this.buttonProximo.Text = "&Próximo";
            this.buttonProximo.UseVisualStyleBackColor = true;
            this.buttonProximo.Click += new System.EventHandler(this.buttonProximo_Click);
            // 
            // buttonAnterior
            // 
            this.buttonAnterior.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnterior.Location = new System.Drawing.Point(514, 515);
            this.buttonAnterior.Name = "buttonAnterior";
            this.buttonAnterior.Size = new System.Drawing.Size(99, 25);
            this.buttonAnterior.TabIndex = 4;
            this.buttonAnterior.Text = "&Anterior";
            this.buttonAnterior.UseVisualStyleBackColor = true;
            this.buttonAnterior.Click += new System.EventHandler(this.buttonAnterior_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSair.Location = new System.Drawing.Point(12, 515);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(99, 25);
            this.buttonSair.TabIndex = 6;
            this.buttonSair.Text = "&Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // pictureBoxTitulo
            // 
            this.pictureBoxTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(32)))), ((int)(((byte)(122)))));
            this.pictureBoxTitulo.Image = global::TemplateTool.Properties.Resources.tfs_template_tool;
            this.pictureBoxTitulo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTitulo.Name = "pictureBoxTitulo";
            this.pictureBoxTitulo.Size = new System.Drawing.Size(731, 108);
            this.pictureBoxTitulo.TabIndex = 7;
            this.pictureBoxTitulo.TabStop = false;
            // 
            // labelVersao
            // 
            this.labelVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(32)))), ((int)(((byte)(122)))));
            this.labelVersao.ForeColor = System.Drawing.Color.White;
            this.labelVersao.Location = new System.Drawing.Point(622, 85);
            this.labelVersao.Name = "labelVersao";
            this.labelVersao.Size = new System.Drawing.Size(100, 23);
            this.labelVersao.TabIndex = 8;
            this.labelVersao.Text = "labelVersao";
            this.labelVersao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 550);
            this.Controls.Add(this.labelVersao);
            this.Controls.Add(this.pictureBoxTitulo);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.buttonAnterior);
            this.Controls.Add(this.buttonProximo);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormPrincipal";
            this.Text = "Template Tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPageBemVindo.ResumeLayout(false);
            this.tabPageSelecaoProjetos.ResumeLayout(false);
            this.tabPageSelecaoProjetos.PerformLayout();
            this.tabPageConfiguracao.ResumeLayout(false);
            this.tabPageConfiguracao.PerformLayout();
            this.groupBoxEdicao.ResumeLayout(false);
            this.groupBoxEdicao.PerformLayout();
            this.tabPageTemplates.ResumeLayout(false);
            this.tabPageTemplates.PerformLayout();
            this.tabPageConfirmacao.ResumeLayout(false);
            this.tabPageConfirmacao.PerformLayout();
            this.tabPageProcessamento.ResumeLayout(false);
            this.tabPageProcessamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSelecaoProjetos;
        private System.Windows.Forms.TabPage tabPageTemplates;
        private System.Windows.Forms.TabPage tabPageConfirmacao;
        private System.Windows.Forms.TabPage tabPageProcessamento;
        private System.Windows.Forms.Button buttonProximo;
        private System.Windows.Forms.Button buttonAnterior;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.Button buttonConectar;
        private System.Windows.Forms.Label labelListaCollections;
        private System.Windows.Forms.ListView listViewCollections;
        private System.Windows.Forms.ColumnHeader columnNome;
        private System.Windows.Forms.Label labelProjetos;
        private System.Windows.Forms.ListView listViewProjetos;
        private System.Windows.Forms.ColumnHeader columnHeaderCollection;
        private System.Windows.Forms.ColumnHeader columnHeaderProjeto;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Label labelSelecioneTiposDeTemplateImportar;
        private System.Windows.Forms.CheckedListBox checkedListBoxTiposDeTemplate;
        private System.Windows.Forms.Label labelSaida;
        private System.Windows.Forms.TextBox textBoxSaida;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBoxConfirmacaoDeComandos;
        private System.Windows.Forms.Label labelConfirmacaoDeExecucaoDeComandos;
        private System.Windows.Forms.CheckBox checkBoxConfirmarExecução;
        private System.Windows.Forms.TabPage tabPageConfiguracao;
        private System.Windows.Forms.Label labelListaDeParametros;
        private System.Windows.Forms.ListView listViewParametros;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.GroupBox groupBoxEdicao;
        private System.Windows.Forms.PictureBox pictureBoxTitulo;
        private System.Windows.Forms.Label labelVersao;
        private System.Windows.Forms.TextBox textBoxValorPropriedade;
        private System.Windows.Forms.TabPage tabPageBemVindo;
        private System.Windows.Forms.RichTextBox richTextBoxBemVindo;
        private System.Windows.Forms.Label labelDicaEdicao;
        private System.Windows.Forms.Label labelValorPropriedade;
        private System.Windows.Forms.Label labelNomePropriedade;
        private System.Windows.Forms.TextBox textBoxNomePropriedade;
        private System.Windows.Forms.Button buttonAdicionarPropriedade;
        private System.Windows.Forms.Button buttonCancelarPropriedade;
        private System.Windows.Forms.Button buttonSalvarPropriedade;
        private System.Windows.Forms.Button buttonRemoverPropriedade;
    }
}

