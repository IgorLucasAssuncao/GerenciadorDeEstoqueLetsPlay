using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Gerenciador_de_estoque
{
    public class TabelaDeCoresDoMenu : ProfessionalColorTable
    {
        //Atributos
        private Color corDeFundo;
        private Color corColunaEsquerda;
        private Color corDaBorda;
        private Color corItemDoMenu;
        private Color corItemSelecionado;

        public TabelaDeCoresDoMenu(bool isMainMenu, Color primarycolor)
        {
            if (isMainMenu)
            {
                corDeFundo = Color.FromArgb(37, 39, 60);
                corColunaEsquerda = Color.FromArgb(32, 33, 51);
                corDaBorda = Color.FromArgb(32, 33, 51);
                corItemDoMenu = primarycolor;
                corItemSelecionado = primarycolor;

            }
            else
            {
                corDeFundo = Color.Gainsboro;
                corColunaEsquerda = Color.LightGray;
                corDaBorda = Color.LightGray;
                corItemDoMenu = primarycolor;
                corItemSelecionado = primarycolor;
            }

        }

        //Override propriedades
        public override Color ToolStripDropDownBackground
        {
            get
            {
                return corDeFundo;
            }

        }
        public override Color MenuBorder
        {
            get
            {
                return corDaBorda;
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return corItemDoMenu;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return corItemSelecionado;
            }
        }

        public override Color ImageMarginGradientBegin 
        {
            get
            {
                return corColunaEsquerda;
            }
        }
        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return corColunaEsquerda;
            }
        }
        public override Color ImageMarginGradientEnd
        {
            get
            {
                return corColunaEsquerda;
            }
        }


    }
}
