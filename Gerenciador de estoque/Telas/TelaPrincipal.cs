using FontAwesome.Sharp; // Biblioteca para usar os ícones do FontAwesome 
using Newtonsoft.Json; //Biblioteca para desserializar o arquivo JSON
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
namespace Gerenciador_de_estoque
{
    public partial class TelaPrincipal : Form
    {
        //campos --Atributos
        private IconButton currentBtn; //Botão que está sendo clicado no momento

        private Panel leftBorderBtn;  // Painel que fica na esquerda do botão, dá o efeito de sombra a esquerda

        private Form currentChildForm; // Formulário atual que está sendo exibido no painel desktop

        private GeraID GeraID;   // Objeto que gera IDs únicos para os produtos e os armazena em uma lista
        private List<Categoria> Categorias;  // Objeto que armazena as categorias dos produtos
        private Lista<Produto> Produtos; //Lista de todos os produtos cadastrados


        //Construtor
        public TelaPrincipal()
        {
            InitializeComponent();
            // RoundCorners();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(10, 60);
            panelMenu.Controls.Add(leftBorderBtn);//Adicionar o painel ao painel menu

            //Tela principal:Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;//Tela maximizada
            

        }
        private void RoundCorners()
        {
            // Define a borda arredondada com um raio de 20 pixels (pode ajustar conforme necessário)
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, 20, 20), 180, 90); // Canto superior esquerdo
            path.AddArc(new Rectangle(Width - 20, 0, 20, 20), 270, 90); // Canto superior direito
            path.AddArc(new Rectangle(Width - 20, Height - 20, 20, 20), 0, 90); // Canto inferior direito
            path.AddArc(new Rectangle(0, Height - 20, 20, 20), 90, 90); // Canto inferior esquerdo
            path.CloseFigure();

            Region = new Region(path);
        }
        //métodos
        private void ActivateForm(Form childform)  //chamar o formulário recebido como parâmetro e exibi-lo no painel desktop
        {
            if (currentChildForm != null) //Se já existir um painel sendo exibido o mesmo será fechado
            {
                currentChildForm.Close();
            }
            currentChildForm = childform;//definir o formulário recebido como formulário atual
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childform);
            panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            childform.Anchor = AnchorStyles.None;
        }

        private void ActivateButton(object Sender, Color color)
        {
            if (Sender != null)
            {
                DesativarBtn();

                //Botão
                currentBtn = (IconButton)Sender;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Borda esquerda do botão
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //icone do formulário principal (Topo)
                iconPanelTop.IconChar = currentBtn.IconChar;
                iconPanelTop.IconColor = color;
                labelTitleForm.Text = currentBtn.Text;
            }
        }

        private void DesativarBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void Reset()
        {
            DesativarBtn();
            leftBorderBtn.Visible = false;
            iconPanelTop.IconChar = IconChar.Home;
            iconPanelTop.IconColor = Color.Gainsboro;
            labelTitleForm.Text = "Home";
            labelTitleForm.ForeColor = Color.Gainsboro;
        }

        private void TelaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Dashboard_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 126, 249));
            // ActivateForm(new TesteEstoque()); Chamar o formulário recebido como parâmetro e exibi-lo no painel desktop
        }

        private void Btn_Estoque_Click(object sender, System.EventArgs e)
        {
            dropDownMenu1.IsMainMenu = true;
            dropDownMenu1.Show(Btn_Estoque, Btn_Estoque.Width, 0);
            ActivateButton(sender, Color.FromArgb(0, 126, 249));

        }

        private void Btn_Financas_Click(object sender, System.EventArgs e)
        {

            dropDownMenu2.IsMainMenu = true;
            dropDownMenu2.Show(Btn_Financas, Btn_Financas.Width, 0);
            ActivateButton(sender, Color.FromArgb(0, 126, 249));
        }

        private void Btn_Ajuda_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 126, 249));
        }

        private void Btn_Sobre_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender, Color.FromArgb(0, 126, 249));
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            Reset();
        }

        //Arrastar a tela por meio do Painel no topo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTopo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void BtnExpand_Click(object sender, System.EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                BtnExpand.IconChar = IconChar.WindowRestore;
            }
            else
            {
                WindowState = FormWindowState.Normal;
                BtnExpand.IconChar = IconChar.WindowMaximize;
            }
        }

        private void BtnMinimize_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void timerDisplayHorario_Tick(object sender, System.EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;

            // Atualize os rótulos com as informações de data e hora formatadas
            labelDate.Text = currentDateTime.ToLongDateString();
            labelTime.Text = currentDateTime.ToLongTimeString();
            // labelDayOfWeek.Text = currentDateTime.DayOfWeek.ToString();
        }

        private void TelaPrincipal_Load(object sender, System.EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;

            // Atualize os rótulos com as informações de data e hora formatadas
            labelDate.Text = currentDateTime.ToLongDateString();
            labelTime.Text = currentDateTime.ToLongTimeString();
            //labelDayOfWeek.Text = currentDateTime.DayOfWeek.ToString();
            timerDisplayHorario.Start();

            Produtos = new Lista<Produto>();
            GeraID = new GeraID();
            Categorias = new List<Categoria>();
            try
            {
                string json = File.ReadAllText("Produtos.json");
                if (!string.IsNullOrEmpty(json))
                {
                    try
                    {
                        List<Produto> ProdutosDesserializados = JsonConvert.DeserializeObject<List<Produto>>(json);

                        foreach (Produto produto in ProdutosDesserializados)
                        {
                            if (produto.Status == true)
                            {
                                Produtos.Add(produto); //Lista duplamente encadeada
                                GeraID.UsedIDs.Add(produto.Id); // Lista padrão
                                Categorias.Add(produto.Categoria);
                            }
                        }
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O estoque está vazio!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {

        }
    }
}