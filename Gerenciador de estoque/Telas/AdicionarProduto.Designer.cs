namespace Gerenciador_de_estoque
{
    partial class AdicionarProduto
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
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.quantidadeBox = new System.Windows.Forms.TextBox();
            this.precoLabel = new System.Windows.Forms.Label();
            this.precoDeCompraBox = new System.Windows.Forms.TextBox();
            this.precoDeVendaLabel = new System.Windows.Forms.Label();
            this.precoDeVendaBox = new System.Windows.Forms.TextBox();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.CategoriaLabel = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.descricaoLabel = new System.Windows.Forms.Label();
            this.adicionarBtn = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // nomeBox
            // 
            this.nomeBox.Location = new System.Drawing.Point(167, 66);
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(160, 20);
            this.nomeBox.TabIndex = 0;
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeLabel.Location = new System.Drawing.Point(4, 64);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(132, 20);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome do produto";
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeLabel.Location = new System.Drawing.Point(37, 111);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(92, 20);
            this.quantidadeLabel.TabIndex = 3;
            this.quantidadeLabel.Text = "Quantidade";
            // 
            // quantidadeBox
            // 
            this.quantidadeBox.Location = new System.Drawing.Point(167, 113);
            this.quantidadeBox.Name = "quantidadeBox";
            this.quantidadeBox.Size = new System.Drawing.Size(160, 20);
            this.quantidadeBox.TabIndex = 2;
            // 
            // precoLabel
            // 
            this.precoLabel.AutoSize = true;
            this.precoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoLabel.Location = new System.Drawing.Point(4, 161);
            this.precoLabel.Name = "precoLabel";
            this.precoLabel.Size = new System.Drawing.Size(129, 20);
            this.precoLabel.TabIndex = 5;
            this.precoLabel.Text = "Preço de compra";
            // 
            // precoDeCompraBox
            // 
            this.precoDeCompraBox.Location = new System.Drawing.Point(167, 163);
            this.precoDeCompraBox.Name = "precoDeCompraBox";
            this.precoDeCompraBox.Size = new System.Drawing.Size(160, 20);
            this.precoDeCompraBox.TabIndex = 4;
            // 
            // precoDeVendaLabel
            // 
            this.precoDeVendaLabel.AutoSize = true;
            this.precoDeVendaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precoDeVendaLabel.Location = new System.Drawing.Point(14, 206);
            this.precoDeVendaLabel.Name = "precoDeVendaLabel";
            this.precoDeVendaLabel.Size = new System.Drawing.Size(119, 20);
            this.precoDeVendaLabel.TabIndex = 7;
            this.precoDeVendaLabel.Text = "Preço de venda";
            // 
            // precoDeVendaBox
            // 
            this.precoDeVendaBox.Location = new System.Drawing.Point(167, 208);
            this.precoDeVendaBox.Name = "precoDeVendaBox";
            this.precoDeVendaBox.Size = new System.Drawing.Size(160, 20);
            this.precoDeVendaBox.TabIndex = 6;
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Location = new System.Drawing.Point(167, 254);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(160, 21);
            this.categoriaComboBox.TabIndex = 8;
            // 
            // CategoriaLabel
            // 
            this.CategoriaLabel.AutoSize = true;
            this.CategoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoriaLabel.Location = new System.Drawing.Point(51, 252);
            this.CategoriaLabel.Name = "CategoriaLabel";
            this.CategoriaLabel.Size = new System.Drawing.Size(78, 20);
            this.CategoriaLabel.TabIndex = 9;
            this.CategoriaLabel.Text = "Categoria";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(167, 312);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(190, 118);
            this.textBox5.TabIndex = 10;
            // 
            // descricaoLabel
            // 
            this.descricaoLabel.AutoSize = true;
            this.descricaoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoLabel.Location = new System.Drawing.Point(51, 312);
            this.descricaoLabel.Name = "descricaoLabel";
            this.descricaoLabel.Size = new System.Drawing.Size(80, 20);
            this.descricaoLabel.TabIndex = 11;
            this.descricaoLabel.Text = "Descrição";
            // 
            // adicionarBtn
            // 
            this.adicionarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adicionarBtn.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.adicionarBtn.IconColor = System.Drawing.Color.Black;
            this.adicionarBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adicionarBtn.IconSize = 30;
            this.adicionarBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.adicionarBtn.Location = new System.Drawing.Point(167, 446);
            this.adicionarBtn.Name = "adicionarBtn";
            this.adicionarBtn.Size = new System.Drawing.Size(190, 35);
            this.adicionarBtn.TabIndex = 12;
            this.adicionarBtn.Text = "Adicionar produto        ";
            this.adicionarBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.adicionarBtn.UseVisualStyleBackColor = true;
            // 
            // AdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(666, 511);
            this.Controls.Add(this.adicionarBtn);
            this.Controls.Add(this.descricaoLabel);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.CategoriaLabel);
            this.Controls.Add(this.categoriaComboBox);
            this.Controls.Add(this.precoDeVendaLabel);
            this.Controls.Add(this.precoDeVendaBox);
            this.Controls.Add(this.precoLabel);
            this.Controls.Add(this.precoDeCompraBox);
            this.Controls.Add(this.quantidadeLabel);
            this.Controls.Add(this.quantidadeBox);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.nomeBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "AdicionarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdicionarProduto";
            this.Load += new System.EventHandler(this.AdicionarProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeBox;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.TextBox quantidadeBox;
        private System.Windows.Forms.Label precoLabel;
        private System.Windows.Forms.TextBox precoDeCompraBox;
        private System.Windows.Forms.Label precoDeVendaLabel;
        private System.Windows.Forms.TextBox precoDeVendaBox;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.Label CategoriaLabel;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label descricaoLabel;
        private FontAwesome.Sharp.IconButton adicionarBtn;
    }
}