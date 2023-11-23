using FontAwesome.Sharp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Drawing.Drawing2D;
using System.Drawing;


namespace Gerenciador_de_estoque
{
    public partial class Login : Form
    {
        private List<User> users;
        private string caminhoArquivo = "User.json";

        public Login()
        {
            InitializeComponent();
            RoundCorners();
            RoundCorners(panel3);
            RoundCorners(panel4);


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
        private void RoundCorners(Panel painel)
        {
           
            int radius = 20; 
            GraphicsPath path = new GraphicsPath();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90); // Canto superior esquerdo
            path.AddArc(new Rectangle(painel.Width - radius, 0, radius, radius), 270, 90); // Canto superior direito
            path.AddArc(new Rectangle(painel.Width - radius, painel.Height - radius, radius, radius), 0, 90); // Canto inferior direito
            path.AddArc(new Rectangle(0, painel.Height - radius, radius, radius), 90, 90); // Canto inferior esquerdo
            path.CloseFigure();

            painel.Region = new Region(path);
        }

        private void BtnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String User = textBox1.Text.Trim();
            String Pass = textBox2.Text.Trim();
            bool login = false;

            foreach (User user in this.users)
            {
                if (user.Autenticar(User, Pass))
                {
                    login = true;
                    break;
                }
            }

            if (login)
            {
                MensagemAviso.Text = "Login efetuado com sucesso!";
                Thread.Sleep(500);
                TelaPrincipal TelaPrincipal = new TelaPrincipal();
                TelaPrincipal.Show();

                Hide();
            }
            else
            {
                MensagemAviso.Text = "Login não efetuado!";
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

     

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string destinatario = linkLabel1.Text.Trim();

            // Cria a URL com o parâmetro "to" para o destinatário
            string url = "https://mail.google.com/mail/?view=cm&fs=1&to=" + Uri.EscapeDataString(destinatario);

            // Abre o navegador padrão com a URL do Gmail e o destinatário preenchido
            System.Diagnostics.Process.Start(url);
        }

        private void Login_Load(object sender, EventArgs e)
        {
          
            var result = File.ReadAllText(caminhoArquivo);
            try
            {
                if (result == null)
                {
                    users = new List<User>
                    {
                        new User("admin","admin")
                    };

                    string item = JsonConvert.SerializeObject(users[0]);

                    // Especifique o caminho do arquivo onde deseja salvar o JSON
                    string caminhoArquivo = "User.json";

                    // Escreve o JSON em um arquivo
                    File.WriteAllText(caminhoArquivo, item);
                }
                else
                {
                    users = JsonConvert.DeserializeObject<List<User>>(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}