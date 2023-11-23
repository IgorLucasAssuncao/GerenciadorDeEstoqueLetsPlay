using System.Windows.Media.Media3D;

namespace Gerenciador_de_estoque
{
    partial class TelaPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.Btn_Sobre = new FontAwesome.Sharp.IconButton();
            this.Btn_Ajuda = new FontAwesome.Sharp.IconButton();
            this.Btn_Financas = new FontAwesome.Sharp.IconButton();
            this.Btn_Estoque = new FontAwesome.Sharp.IconButton();
            this.Btn_Dashboard = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTopo = new System.Windows.Forms.Panel();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.BtnExpand = new FontAwesome.Sharp.IconButton();
            this.BtnExit = new FontAwesome.Sharp.IconButton();
            this.labelTitleForm = new System.Windows.Forms.Label();
            this.iconPanelTop = new FontAwesome.Sharp.IconPictureBox();
            this.timerDisplayHorario = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.testeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dEToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dEToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dEToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.deToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.dEToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.dEToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.dropDownMenu1 = new Gerenciador_de_estoque.DropDownMenu(this.components);
            this.visãoGeralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerenciarCategoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.alertaDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dropDownMenu2 = new Gerenciador_de_estoque.DropDownMenu(this.components);
            this.registrarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarDívidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTopo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPanelTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.dropDownMenu1.SuspendLayout();
            this.dropDownMenu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panelMenu.Controls.Add(this.Btn_Sobre);
            this.panelMenu.Controls.Add(this.Btn_Ajuda);
            this.panelMenu.Controls.Add(this.Btn_Financas);
            this.panelMenu.Controls.Add(this.Btn_Estoque);
            this.panelMenu.Controls.Add(this.Btn_Dashboard);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 697);
            this.panelMenu.TabIndex = 0;
            // 
            // Btn_Sobre
            // 
            this.Btn_Sobre.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Sobre.FlatAppearance.BorderSize = 0;
            this.Btn_Sobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Sobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Sobre.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Sobre.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.Btn_Sobre.IconColor = System.Drawing.Color.White;
            this.Btn_Sobre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Sobre.IconSize = 40;
            this.Btn_Sobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sobre.Location = new System.Drawing.Point(0, 360);
            this.Btn_Sobre.Name = "Btn_Sobre";
            this.Btn_Sobre.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Sobre.Size = new System.Drawing.Size(220, 60);
            this.Btn_Sobre.TabIndex = 5;
            this.Btn_Sobre.Text = "Sobre";
            this.Btn_Sobre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Sobre.UseVisualStyleBackColor = true;
            this.Btn_Sobre.Click += new System.EventHandler(this.Btn_Sobre_Click);
            // 
            // Btn_Ajuda
            // 
            this.Btn_Ajuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Ajuda.FlatAppearance.BorderSize = 0;
            this.Btn_Ajuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ajuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajuda.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Ajuda.IconChar = FontAwesome.Sharp.IconChar.UniversalAccess;
            this.Btn_Ajuda.IconColor = System.Drawing.Color.White;
            this.Btn_Ajuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Ajuda.IconSize = 40;
            this.Btn_Ajuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ajuda.Location = new System.Drawing.Point(0, 300);
            this.Btn_Ajuda.Name = "Btn_Ajuda";
            this.Btn_Ajuda.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Ajuda.Size = new System.Drawing.Size(220, 60);
            this.Btn_Ajuda.TabIndex = 4;
            this.Btn_Ajuda.Text = "Ajuda";
            this.Btn_Ajuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Ajuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Ajuda.UseVisualStyleBackColor = true;
            this.Btn_Ajuda.Click += new System.EventHandler(this.Btn_Ajuda_Click);
            // 
            // Btn_Financas
            // 
            this.Btn_Financas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Financas.FlatAppearance.BorderSize = 0;
            this.Btn_Financas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Financas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Financas.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Financas.IconChar = FontAwesome.Sharp.IconChar.BalanceScale;
            this.Btn_Financas.IconColor = System.Drawing.Color.White;
            this.Btn_Financas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Financas.IconSize = 40;
            this.Btn_Financas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Financas.Location = new System.Drawing.Point(0, 240);
            this.Btn_Financas.Name = "Btn_Financas";
            this.Btn_Financas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Financas.Size = new System.Drawing.Size(220, 60);
            this.Btn_Financas.TabIndex = 3;
            this.Btn_Financas.Text = "Finanças";
            this.Btn_Financas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Financas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Financas.UseVisualStyleBackColor = true;
            this.Btn_Financas.Click += new System.EventHandler(this.Btn_Financas_Click);
            // 
            // Btn_Estoque
            // 
            this.Btn_Estoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Estoque.FlatAppearance.BorderSize = 0;
            this.Btn_Estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Estoque.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Estoque.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.Btn_Estoque.IconColor = System.Drawing.Color.White;
            this.Btn_Estoque.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Estoque.IconSize = 40;
            this.Btn_Estoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Estoque.Location = new System.Drawing.Point(0, 180);
            this.Btn_Estoque.Name = "Btn_Estoque";
            this.Btn_Estoque.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Estoque.Size = new System.Drawing.Size(220, 60);
            this.Btn_Estoque.TabIndex = 2;
            this.Btn_Estoque.Text = "Estoque";
            this.Btn_Estoque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Estoque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Estoque.UseVisualStyleBackColor = true;
            this.Btn_Estoque.Click += new System.EventHandler(this.Btn_Estoque_Click);
            // 
            // Btn_Dashboard
            // 
            this.Btn_Dashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Dashboard.FlatAppearance.BorderSize = 0;
            this.Btn_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Dashboard.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Dashboard.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.Btn_Dashboard.IconColor = System.Drawing.Color.White;
            this.Btn_Dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Dashboard.IconSize = 40;
            this.Btn_Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Dashboard.Location = new System.Drawing.Point(0, 120);
            this.Btn_Dashboard.Name = "Btn_Dashboard";
            this.Btn_Dashboard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Dashboard.Size = new System.Drawing.Size(220, 60);
            this.Btn_Dashboard.TabIndex = 1;
            this.Btn_Dashboard.Text = "Dashboards";
            this.Btn_Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Dashboard.UseVisualStyleBackColor = true;
            this.Btn_Dashboard.Click += new System.EventHandler(this.Btn_Dashboard_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 120);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gerenciador_de_estoque.Properties.Resources.Imagem_do_WhatsApp_de_2023_11_17_à_s__17_42_59_1e3d94cd;
            this.pictureBox1.Location = new System.Drawing.Point(-24, -65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.panelTopo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTopo.Controls.Add(this.BtnMinimize);
            this.panelTopo.Controls.Add(this.BtnExpand);
            this.panelTopo.Controls.Add(this.BtnExit);
            this.panelTopo.Controls.Add(this.labelTitleForm);
            this.panelTopo.Controls.Add(this.iconPanelTop);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(220, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(757, 125);
            this.panelTopo.TabIndex = 0;
            this.panelTopo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopo_MouseDown);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.BtnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimize.IconSize = 23;
            this.BtnMinimize.Location = new System.Drawing.Point(680, 5);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(20, 17);
            this.BtnMinimize.TabIndex = 4;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // BtnExpand
            // 
            this.BtnExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExpand.FlatAppearance.BorderSize = 0;
            this.BtnExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExpand.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnExpand.IconColor = System.Drawing.Color.Aqua;
            this.BtnExpand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExpand.IconSize = 23;
            this.BtnExpand.Location = new System.Drawing.Point(706, 5);
            this.BtnExpand.Name = "BtnExpand";
            this.BtnExpand.Size = new System.Drawing.Size(20, 17);
            this.BtnExpand.TabIndex = 3;
            this.BtnExpand.UseVisualStyleBackColor = true;
            this.BtnExpand.Click += new System.EventHandler(this.BtnExpand_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.BtnExit.IconColor = System.Drawing.Color.Red;
            this.BtnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnExit.IconSize = 28;
            this.BtnExit.Location = new System.Drawing.Point(732, 5);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(20, 17);
            this.BtnExit.TabIndex = 2;
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // labelTitleForm
            // 
            this.labelTitleForm.AutoSize = true;
            this.labelTitleForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitleForm.Location = new System.Drawing.Point(79, 57);
            this.labelTitleForm.Name = "labelTitleForm";
            this.labelTitleForm.Size = new System.Drawing.Size(127, 25);
            this.labelTitleForm.TabIndex = 1;
            this.labelTitleForm.Text = "Página Inicial";
            // 
            // iconPanelTop
            // 
            this.iconPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.iconPanelTop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPanelTop.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.iconPanelTop.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPanelTop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPanelTop.IconSize = 35;
            this.iconPanelTop.Location = new System.Drawing.Point(47, 52);
            this.iconPanelTop.Name = "iconPanelTop";
            this.iconPanelTop.Size = new System.Drawing.Size(35, 35);
            this.iconPanelTop.TabIndex = 0;
            this.iconPanelTop.TabStop = false;
            // 
            // timerDisplayHorario
            // 
            this.timerDisplayHorario.Interval = 1000;
            this.timerDisplayHorario.Tick += new System.EventHandler(this.timerDisplayHorario_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::Gerenciador_de_estoque.Properties.Resources.Imagem_do_WhatsApp_de_2023_11_17_à_s__17_42_59_1e3d94cd;
            this.pictureBox2.Location = new System.Drawing.Point(149, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(447, 259);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Location = new System.Drawing.Point(214, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 119);
            this.panel2.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTime.Location = new System.Drawing.Point(86, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(109, 39);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "label2";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDate.Location = new System.Drawing.Point(18, 39);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(51, 20);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "label1";
            // 
            // panelDesktop
            // 
            this.panelDesktop.AutoSize = true;
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(58)))));
            this.panelDesktop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDesktop.Controls.Add(this.panel2);
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 125);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(757, 572);
            this.panelDesktop.TabIndex = 2;
            // 
            // testeToolStripMenuItem
            // 
            this.testeToolStripMenuItem.Name = "testeToolStripMenuItem";
            this.testeToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // deToolStripMenuItem
            // 
            this.deToolStripMenuItem.Name = "deToolStripMenuItem";
            this.deToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // testeToolStripMenuItem1
            // 
            this.testeToolStripMenuItem1.Name = "testeToolStripMenuItem1";
            this.testeToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // testeToolStripMenuItem2
            // 
            this.testeToolStripMenuItem2.Name = "testeToolStripMenuItem2";
            this.testeToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // deToolStripMenuItem1
            // 
            this.deToolStripMenuItem1.Name = "deToolStripMenuItem1";
            this.deToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // dEToolStripMenuItem2
            // 
            this.dEToolStripMenuItem2.Name = "dEToolStripMenuItem2";
            this.dEToolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // dEToolStripMenuItem3
            // 
            this.dEToolStripMenuItem3.Name = "dEToolStripMenuItem3";
            this.dEToolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
            // 
            // dEToolStripMenuItem4
            // 
            this.dEToolStripMenuItem4.Name = "dEToolStripMenuItem4";
            this.dEToolStripMenuItem4.Size = new System.Drawing.Size(32, 19);
            // 
            // deToolStripMenuItem5
            // 
            this.deToolStripMenuItem5.Name = "deToolStripMenuItem5";
            this.deToolStripMenuItem5.Size = new System.Drawing.Size(32, 19);
            // 
            // dEToolStripMenuItem6
            // 
            this.dEToolStripMenuItem6.Name = "dEToolStripMenuItem6";
            this.dEToolStripMenuItem6.Size = new System.Drawing.Size(32, 19);
            // 
            // dEToolStripMenuItem7
            // 
            this.dEToolStripMenuItem7.Name = "dEToolStripMenuItem7";
            this.dEToolStripMenuItem7.Size = new System.Drawing.Size(32, 19);
            // 
            // dropDownMenu1
            // 
            this.dropDownMenu1.IsMainMenu = false;
            this.dropDownMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visãoGeralToolStripMenuItem,
            this.adicionarProdutoToolStripMenuItem,
            this.atualizarProdutoToolStripMenuItem,
            this.removerToolStripMenuItem2,
            this.gerenciarFornecedoresToolStripMenuItem,
            this.gerenciarCategoriasToolStripMenuItem,
            this.alertaDeEstoqueToolStripMenuItem});
            this.dropDownMenu1.MenuItemHeigtht = 25;
            this.dropDownMenu1.MenuItemTextColor = System.Drawing.Color.Gainsboro;
            this.dropDownMenu1.Name = "dropMenuEstoque";
            this.dropDownMenu1.PrimaryColor = System.Drawing.Color.MediumAquamarine;
            this.dropDownMenu1.Size = new System.Drawing.Size(197, 158);
            // 
            // visãoGeralToolStripMenuItem
            // 
            this.visãoGeralToolStripMenuItem.Name = "visãoGeralToolStripMenuItem";
            this.visãoGeralToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.visãoGeralToolStripMenuItem.Text = "Visão Geral";
            // 
            // adicionarProdutoToolStripMenuItem
            // 
            this.adicionarProdutoToolStripMenuItem.Name = "adicionarProdutoToolStripMenuItem";
            this.adicionarProdutoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.adicionarProdutoToolStripMenuItem.Text = "Adicionar Produto";
            // 
            // atualizarProdutoToolStripMenuItem
            // 
            this.atualizarProdutoToolStripMenuItem.Name = "atualizarProdutoToolStripMenuItem";
            this.atualizarProdutoToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.atualizarProdutoToolStripMenuItem.Text = "Atualizar Produto";
            // 
            // removerToolStripMenuItem2
            // 
            this.removerToolStripMenuItem2.Name = "removerToolStripMenuItem2";
            this.removerToolStripMenuItem2.Size = new System.Drawing.Size(196, 22);
            this.removerToolStripMenuItem2.Text = "Remover";
            // 
            // gerenciarFornecedoresToolStripMenuItem
            // 
            this.gerenciarFornecedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.atualizarToolStripMenuItem,
            this.removerToolStripMenuItem});
            this.gerenciarFornecedoresToolStripMenuItem.Name = "gerenciarFornecedoresToolStripMenuItem";
            this.gerenciarFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.gerenciarFornecedoresToolStripMenuItem.Text = "Gerenciar fornecedores";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem.Text = "Adicionar";
            // 
            // atualizarToolStripMenuItem
            // 
            this.atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            this.atualizarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.atualizarToolStripMenuItem.Text = "Atualizar";
            // 
            // removerToolStripMenuItem
            // 
            this.removerToolStripMenuItem.Name = "removerToolStripMenuItem";
            this.removerToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.removerToolStripMenuItem.Text = "Remover";
            // 
            // gerenciarCategoriasToolStripMenuItem
            // 
            this.gerenciarCategoriasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem1,
            this.atualizarToolStripMenuItem1,
            this.removerToolStripMenuItem1});
            this.gerenciarCategoriasToolStripMenuItem.Name = "gerenciarCategoriasToolStripMenuItem";
            this.gerenciarCategoriasToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.gerenciarCategoriasToolStripMenuItem.Text = "Gerenciar Categorias";
            // 
            // adicionarToolStripMenuItem1
            // 
            this.adicionarToolStripMenuItem1.Name = "adicionarToolStripMenuItem1";
            this.adicionarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.adicionarToolStripMenuItem1.Text = "Adicionar";
            // 
            // atualizarToolStripMenuItem1
            // 
            this.atualizarToolStripMenuItem1.Name = "atualizarToolStripMenuItem1";
            this.atualizarToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.atualizarToolStripMenuItem1.Text = "Atualizar";
            // 
            // removerToolStripMenuItem1
            // 
            this.removerToolStripMenuItem1.Name = "removerToolStripMenuItem1";
            this.removerToolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.removerToolStripMenuItem1.Text = "Remover";
            // 
            // alertaDeEstoqueToolStripMenuItem
            // 
            this.alertaDeEstoqueToolStripMenuItem.Name = "alertaDeEstoqueToolStripMenuItem";
            this.alertaDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.alertaDeEstoqueToolStripMenuItem.Text = "Alerta de Estoque";
            // 
            // dropDownMenu2
            // 
            this.dropDownMenu2.IsMainMenu = false;
            this.dropDownMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarVendaToolStripMenuItem,
            this.históricoDeVendasToolStripMenuItem,
            this.cadastrarDívidaToolStripMenuItem});
            this.dropDownMenu2.MenuItemHeigtht = 25;
            this.dropDownMenu2.MenuItemTextColor = System.Drawing.Color.Gainsboro;
            this.dropDownMenu2.Name = "dropDownMenu2";
            this.dropDownMenu2.PrimaryColor = System.Drawing.Color.MediumAquamarine;
            this.dropDownMenu2.Size = new System.Drawing.Size(179, 70);
            // 
            // registrarVendaToolStripMenuItem
            // 
            this.registrarVendaToolStripMenuItem.Name = "registrarVendaToolStripMenuItem";
            this.registrarVendaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.registrarVendaToolStripMenuItem.Text = "Registrar Venda";
            // 
            // históricoDeVendasToolStripMenuItem
            // 
            this.históricoDeVendasToolStripMenuItem.Name = "históricoDeVendasToolStripMenuItem";
            this.históricoDeVendasToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.históricoDeVendasToolStripMenuItem.Text = "Histórico de vendas";
            // 
            // cadastrarDívidaToolStripMenuItem
            // 
            this.cadastrarDívidaToolStripMenuItem.Name = "cadastrarDívidaToolStripMenuItem";
            this.cadastrarDívidaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cadastrarDívidaToolStripMenuItem.Text = "Cadastrar dívida";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(977, 697);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTopo);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(993, 736);
            this.Name = "TelaPrincipal";
            this.Text = "Gerenciador";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTopo.ResumeLayout(false);
            this.panelTopo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPanelTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.dropDownMenu1.ResumeLayout(false);
            this.dropDownMenu2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton Btn_Dashboard;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Btn_Sobre;
        private FontAwesome.Sharp.IconButton Btn_Ajuda;
        private FontAwesome.Sharp.IconButton Btn_Financas;
        private FontAwesome.Sharp.IconButton Btn_Estoque;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTopo;
        private FontAwesome.Sharp.IconPictureBox iconPanelTop;
        private System.Windows.Forms.Label labelTitleForm;
        private FontAwesome.Sharp.IconButton BtnExit;
        private FontAwesome.Sharp.IconButton BtnExpand;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private System.Windows.Forms.Timer timerDisplayHorario;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dEToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dEToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem dEToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem dEToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem dEToolStripMenuItem7;
        private DropDownMenu dropDownMenu1;
        private System.Windows.Forms.ToolStripMenuItem visãoGeralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerenciarCategoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem atualizarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem alertaDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerToolStripMenuItem2;
        private DropDownMenu dropDownMenu2;
        private System.Windows.Forms.ToolStripMenuItem registrarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarDívidaToolStripMenuItem;
    }
}