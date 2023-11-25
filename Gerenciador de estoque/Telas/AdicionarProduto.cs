using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerenciador_de_estoque
{
    public partial class AdicionarProduto : Form
    {
        private List<Produto> Produtos;
        private List<Categoria> Categorias;
        private GeraID IdsGerados;

        public AdicionarProduto(List<Produto> produtos, GeraID idsGerados, List<Categoria> categoriasExistentes)
        {
            this.Produtos = produtos;
            this.Categorias = categoriasExistentes;
            this.IdsGerados = idsGerados;
            InitializeComponent();
        }

        private void AdicionarProduto_Load(object sender, EventArgs e)
        {
            if (Categorias == null)
            {
                categoriaComboBox.Enabled = false;
            }
            else
            {
                categoriaComboBox.Enabled = true;
                categoriaComboBox.Items.Clear();
                foreach (Categoria categoria in Categorias)
                {
                    categoriaComboBox.Items.Add(categoria.Nome);
                }
                categoriaComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            }

        }
    }
}
