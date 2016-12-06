using System;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace TemplateTool
{
    public partial class MainForm : Form
    {
        private const string LBL_DESCONECTAR = "&Desconectar";
        private const string LBL_CONECTAR = "&Conectar";

        private const string TAB_WELCOME = "tabPageBemVindo";
        private const string TAB_PROJECTS_SELECTION = "tabPageSelecaoProjetos";
        private const string TAB_CONFIG = "tabPageConfiguracao";
        private const string TAB_TEMPLATES = "tabPageTemplates";
        private const string TAB_ACCEPTANCE = "tabPageConfirmacao";
        private const string TAB_PROCESS = "tabPageProcessamento";
        private string[] TAB_SEQ = new string[] { TAB_WELCOME, TAB_PROJECTS_SELECTION, TAB_TEMPLATES, TAB_CONFIG, TAB_ACCEPTANCE, TAB_PROCESS };

        private IDictionary<string, TabPage> _TabPages = new Dictionary<string, TabPage>();
        private int _TabPageActivated = 0;
        private WitToolProperties _Properties = new WitToolProperties();
        private TFSService _TfsService = null;

        public MainForm()
        {
            InitializeComponent();
            SetupInterface();
        }

        private void SetupInterface()
        {
            ProcessTab(TAB_SEQ[_TabPageActivated]);
            LoadTabPages();
            UpdateTabs();
            LoadPreferences();
            LoadVersion();
        }

        private void LoadTabPages()
        {
            foreach (TabPage tp in tabControl1.TabPages)
            {
                _TabPages.Add(tp.Name, tp);
            }
        }

        #region Eventos
        private void buttonConectar_Click(object sender, EventArgs e)
        {
            if (!IsConnected())
            {
                Connect();
            }
            else
            {
                Disconnect();
            }
        }

        private void listViewProjetos_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            ProcessSelectProjectsTab();
        }

        private void listViewCollections_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            listViewProjetos.Items.Clear();

            List<string> collectionsSelecionadas = GetSelectedCollections();
            List<Project> projetos = _TfsService.GetProjects(collectionsSelecionadas);

            projetos.ForEach((project) =>
            {
                ListViewItem lvi = new ListViewItem(new string[] { project.Collection.Name, project.Nome });
                lvi.Checked = true;
                listViewProjetos.Items.Add(lvi);
            });

            ProcessSelectProjectsTab();
        }

        private void buttonProximo_Click(object sender, EventArgs e)
        {
            _TabPageActivated++;
            UpdateTabs();
            ProcessTab(TAB_SEQ[_TabPageActivated]);
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {
            _TabPageActivated--;
            UpdateTabs();
            ProcessTab(TAB_SEQ[_TabPageActivated]);
        }

        private void checkBoxConfirmarExecução_CheckedChanged(object sender, EventArgs e)
        {
            buttonProximo.Enabled = checkBoxConfirmarExecução.Checked && textBoxConfirmacaoDeComandos.Text.Trim().Length > 0;
        }

        private void checkedListBoxTiposDeTemplate_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            buttonProximo.Enabled = (e.NewValue == CheckState.Checked || checkedListBoxTiposDeTemplate.CheckedItems.Count > 1);
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool sair = ProcessExit();

            e.Cancel = !sair;
        }

        private void listViewParametros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewParametros.SelectedItems.Count > 0)
            {
                textBoxNomePropriedade.Text = listViewParametros.SelectedItems[0].SubItems[0].Text;
                textBoxValorPropriedade.Text = listViewParametros.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void textBoxValorPropriedade_Leave(object sender, EventArgs e)
        {
            if (listViewParametros.SelectedItems.Count > 0)
            {
                listViewParametros.SelectedItems[0].SubItems[1].Text = textBoxValorPropriedade.Text;
                this._Properties.Set(
                    listViewParametros.SelectedItems[0].SubItems[0].Text,
                    listViewParametros.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void listViewParametros_DoubleClick(object sender, EventArgs e)
        {
            UpdatePropertyEditionControls(true);
            textBoxValorPropriedade.Focus();
        }

        private void listViewParametros_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                textBoxValorPropriedade.Focus();
            }
        }

        private void buttonAdicionarPropriedade_Click(object sender, EventArgs e)
        {
            UpdatePropertyEditionControls(true);

            textBoxNomePropriedade.Text = string.Empty;
            textBoxValorPropriedade.Text = string.Empty;
        }

        private void buttonSalvarPropriedade_Click(object sender, EventArgs e)
        {
            if (textBoxNomePropriedade.Text.Trim().Length ==0)
            {
                ShowErrorMessage("O nome da propriedade não ser vazio!");
                return;
            }

            string propriedade = _Properties.Set(textBoxNomePropriedade.Text, textBoxValorPropriedade.Text);
            _Properties.Save();

            ListViewItem lvi = GetPropertyListViewByPropertyName(propriedade);

            if (lvi != null)
            {
                lvi.SubItems[1].Text = textBoxValorPropriedade.Text;
            }
            else
            {
                lvi = new ListViewItem(new string[] { propriedade, textBoxValorPropriedade.Text });
                listViewParametros.Items.Add(lvi);
            }

            UpdatePropertyEditionControls(false);
        }

        private void buttonCancelarPropriedade_Click(object sender, EventArgs e)
        {
            UpdatePropertyEditionControls(false);

            if (listViewParametros.SelectedItems.Count == 1)
            {
                textBoxNomePropriedade.Text = listViewParametros.SelectedItems[0].SubItems[0].Text;
                textBoxValorPropriedade.Text = listViewParametros.SelectedItems[0].SubItems[1].Text;
            }
            else
            {
                textBoxNomePropriedade.Text = string.Empty;
                textBoxValorPropriedade.Text = string.Empty;
            }
        }

        private void buttonRemoverPropriedade_Click(object sender, EventArgs e)
        {
            if (listViewParametros.SelectedItems.Count == 1)
            {
                string propriedade = listViewParametros.SelectedItems[0].SubItems[0].Text;
                _Properties.Remove(propriedade);

                listViewParametros.Items.Remove(listViewParametros.SelectedItems[0]);

                textBoxNomePropriedade.Text = string.Empty;
                textBoxValorPropriedade.Text = string.Empty;
            }
            else
            {
                ShowErrorMessage("Selecione uma propriedade para remover!");
            }
        }
        #endregion

        private List<string> GetSelectedCollections()
        {
            List<string> collections = new List<string>();

            foreach (ListViewItem lvi in listViewCollections.CheckedItems)
            {
                collections.Add(lvi.Text);
            }

            return collections;
        }

        private List<Project> GetSelectedProjects()
        {
            List<Project> projects = new List<Project>();

            foreach (ListViewItem lvi in listViewProjetos.CheckedItems)
            {
                string nomeDaCollection = lvi.SubItems[0].Text;
                string nomeDoprojeto = lvi.SubItems[1].Text;
                Project project = new Project(new Collection(nomeDaCollection), nomeDoprojeto);

                projects.Add(project);
            }

            return projects;
        }

        private bool IsConnected()
        {
            return this._TfsService != null;
        }

        private void Connect()
        {
            _TfsService = new TFSService(textBoxUrl.Text);

            listViewCollections.Items.Clear();
            listViewProjetos.Items.Clear();

            try
            {
                foreach (Collection c in _TfsService.GetCollections())
                {
                    listViewCollections.Items.Add(c.Name);
                }

                buttonConectar.Text = LBL_DESCONECTAR;
                buttonConectar.Enabled = false;
                textBoxUrl.Enabled = false;

                ProcessSelectProjectsTab();
            }
            catch(Exception ex)
            {
                ShowErrorMessage($"Erro ao conectar: {ex.Message}");
                Disconnect();
            }
            finally
            {
                buttonConectar.Enabled = true;
            }
        }

        private void Disconnect()
        {
            _TfsService = null;

            buttonConectar.Text = LBL_CONECTAR;
            buttonProximo.Enabled = false;
            textBoxUrl.Enabled = true;

            ClearProjectsAndCollectionsList();
        }

        private void ClearProjectsAndCollectionsList()
        {
            listViewCollections.Items.Clear();
            listViewProjetos.Items.Clear();
        }

        private void ProcessWelcomeTab()
        {
            buttonAnterior.Enabled = false;
            buttonProximo.Enabled = true;

            richTextBoxBemVindo.Rtf = Properties.Resources.txt_bem_vindo;
        }

        private void ProcessSelectProjectsTab()
        {
            if (IsConnected() && listViewProjetos.CheckedItems.Count > 0)
            {
                buttonAnterior.Enabled = false;
                buttonProximo.Enabled = true;
            }
            else
            {
                buttonAnterior.Enabled = false;
                buttonProximo.Enabled = false;
            }
        }

        private void ProcessConfigTab()
        {
            UpdatePropertyEditionControls(false);

            _Properties.TfsUrl = textBoxUrl.Text;

            listViewParametros.Items.Clear();
            foreach (KeyValuePair<string, string> kvp in _Properties.Get())
            {
                ListViewItem lvi = new ListViewItem(new string[] { kvp.Key, kvp.Value });
                listViewParametros.Items.Add(lvi);
            }
        }

        private void ProcessTemplateTab()
        {
            buttonAnterior.Enabled = true;
            buttonProximo.Enabled = checkedListBoxTiposDeTemplate.CheckedItems.Count > 0;

            if (checkedListBoxTiposDeTemplate.Items.Count == 0)
            {
                Array.ForEach<Template>(
                    Template.CarregarTemplates(),
                    t => checkedListBoxTiposDeTemplate.Items.Add(t));
            }
        }

        private void ProcessAcceptanceTab()
        {
            buttonAnterior.Enabled = true;
            buttonProximo.Enabled = false;
            checkBoxConfirmarExecução.Checked = false;

            CommandProcessor pc = new CommandProcessor(this._Properties);
            List<string> commands = pc.ObterComandos(GetSelectedTemplates(), GetSelectedProjects());
            StringBuilder sb = new StringBuilder();

            commands.ToList().ForEach(comando => {
                sb.Append(comando);
                sb.Append(Environment.NewLine);
                });

            sb.Append(Environment.NewLine);
            sb.Append("Total de comandos: ");
            sb.Append(commands.Count);
            textBoxConfirmacaoDeComandos.Text = sb.ToString();
        }

        private void ProcessProcessingTab()
        {
            buttonAnterior.Enabled = false;
            buttonProximo.Enabled = false;
            textBoxSaida.Text = string.Empty;
            CommandProcessor pc = new CommandProcessor(this._Properties);
            IList<string> comandos = pc.ObterComandos(GetSelectedTemplates(), GetSelectedProjects());
            StringBuilder sb = new StringBuilder();
            int erros = 0;
            int contagem = 0;

            progressBar1.Value = 0;
            progressBar1.Maximum = comandos.Count;
            progressBar1.Minimum = 0;
            comandos.ToList().ForEach(comando => {
                ExecutedCommand exec = pc.ExecuteCommand(comando);

                sb
                    .Clear()
                    .Append(comando)
                    .Append(Environment.NewLine)
                    .Append(exec.ReturnedText)
                    .Append(Environment.NewLine)
                    .Append(exec.Code == 0 ? "[ok]" : "[erro]")
                    .Append(Environment.NewLine)
                    .Append(Environment.NewLine);

                if (exec.Code != 0)
                {
                    erros++;
                }

                textBoxSaida.Text += sb.ToString();

                ScrollOutputProcessText();
                progressBar1.Value = ++contagem;
                Application.DoEvents();
            });

            textBoxSaida.Text += $"Comandos executados: {comandos.Count}{Environment.NewLine}";
            textBoxSaida.Text += $"Comandos com erro: {erros}{Environment.NewLine}";
            ScrollOutputProcessText();
            buttonAnterior.Enabled = true;
        }

        private void ScrollOutputProcessText()
        {
            textBoxSaida.SelectionStart = textBoxSaida.Text.Length - 1;
            textBoxSaida.SelectionLength = 0;
            textBoxSaida.ScrollToCaret();
        }

        private Template[] GetSelectedTemplates()
        {
            Template[] templates = new Template[checkedListBoxTiposDeTemplate.CheckedItems.Count];

            for(int i = 0; i < checkedListBoxTiposDeTemplate.CheckedItems.Count; i++)
            {
                templates[i] = (Template)checkedListBoxTiposDeTemplate.CheckedItems[i];
            }

            return templates;
        }

        private void UpdateTabs()
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(_TabPages[TAB_SEQ[_TabPageActivated]]);
        }

        private void ProcessTab(string tabPageName)
        {
            switch (tabPageName)
            {
                case TAB_WELCOME:
                    ProcessWelcomeTab();
                    break;

                case TAB_PROJECTS_SELECTION:
                    ProcessSelectProjectsTab();
                    break;

                case TAB_CONFIG:
                    ProcessConfigTab();
                    break;

                case TAB_TEMPLATES:
                    ProcessTemplateTab();
                    break;

                case TAB_ACCEPTANCE:
                    ProcessAcceptanceTab();
                    break;

                case TAB_PROCESS:
                    ProcessProcessingTab();
                    break;

                default:
                    ShowErrorMessage("Guia não cadastrada: " + tabPageName);
                    break;
            }
        }

        private void ShowErrorMessage(string mensagem)
        {
            MessageBox.Show(this, mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadPreferences()
        {
            textBoxUrl.Text = _Properties.TfsUrl;
        }

        private void LoadVersion()
        {
            labelVersao.Text = Application.ProductVersion;
        }

        private bool ProcessExit()
        {
            DialogResult ret = MessageBox.Show(this, "Sair do programa?", "Confirmação", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Asterisk);

            if (ret == DialogResult.Yes)
            {
                _Properties.Save();
                return true;
            }

            return false;
        }

        private IDictionary<string, string> GetPropertiesList()
        {
            IDictionary<string, string> ret = new Dictionary<string, string>();
            foreach(ListViewItem lvi in listViewParametros.Items)
            {
                ret.Add(lvi.SubItems[0].Text, lvi.SubItems[1].Text);
            }

            return ret;
        }

        private void UpdatePropertyEditionControls(bool emEdicao)
        {
            textBoxNomePropriedade.Enabled = emEdicao;
            textBoxValorPropriedade.Enabled = emEdicao;
            buttonAdicionarPropriedade.Enabled = !emEdicao;
            buttonCancelarPropriedade.Enabled = emEdicao;
            buttonSalvarPropriedade.Enabled = emEdicao;
            buttonRemoverPropriedade.Enabled = !emEdicao;
            buttonProximo.Enabled = !emEdicao;
            buttonAnterior.Enabled = !emEdicao;
            listViewParametros.Enabled = !emEdicao;
        }

        private ListViewItem GetPropertyListViewByPropertyName(string nome)
        {
            foreach(ListViewItem lvi in listViewParametros.Items)
            {
                if (lvi.SubItems[0].Text.Equals(nome))
                {
                    return lvi;
                }
            }

            return null;
        }
    }
}