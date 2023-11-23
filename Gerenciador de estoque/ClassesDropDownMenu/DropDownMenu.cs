using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Controls;

namespace Gerenciador_de_estoque
{
    public class DropDownMenu : ContextMenuStrip
    {
        //Atributos
        private bool isMainMenu;
        private int menuItemHeigtht = 25;
        private Color menuItemTextColor = Color.Gainsboro;
        private Color primaryColor = Color.MediumAquamarine;

        private Bitmap menuItemHeaderSize;

        //Construtor
        public DropDownMenu(IContainer container)
            : base(container)
        { } 
        [Browsable(false)]
        public bool IsMainMenu { get => isMainMenu; set => isMainMenu = value; }
        [Browsable(false)]
        public int MenuItemHeigtht { get => menuItemHeigtht; set => menuItemHeigtht = value; }
        [Browsable(false)]
        public Color MenuItemTextColor { get => menuItemTextColor; set => menuItemTextColor = value; }
        [Browsable(false)]
        public Color PrimaryColor { get => primaryColor; set => primaryColor = value; }

        //métodos
        //Quanto mais LOOPS Mais léveis de subitens
        private void LoadMenuItemAppearance()
        {
            if (isMainMenu)
            {
                menuItemHeaderSize = new Bitmap(25, 45);
                MenuItemTextColor = Color.Gainsboro;
            }
            else
            {
                menuItemHeaderSize = new Bitmap(15, menuItemHeigtht);
            }
            foreach (ToolStripMenuItem MenuItem in this.Items)
            {
                MenuItem.ForeColor = menuItemTextColor;
                MenuItem.ImageScaling = ToolStripItemImageScaling.None;
                if (MenuItem.Image == null)
                {
                    MenuItem.Image = menuItemHeaderSize;
                }

                foreach (ToolStripMenuItem MenuItem2 in MenuItem.DropDownItems)
                {
                    MenuItem2.ForeColor = menuItemTextColor;
                    MenuItem2.ImageScaling = ToolStripItemImageScaling.None;
                    if (MenuItem2.Image == null)
                    {
                        MenuItem2.Image = menuItemHeaderSize;
                    }
                    foreach (ToolStripMenuItem MenuItem3 in MenuItem2.DropDownItems)
                    {
                        MenuItem3.ForeColor = menuItemTextColor;
                        MenuItem3.ImageScaling = ToolStripItemImageScaling.None;
                        if (MenuItem3.Image == null)
                        {
                            MenuItem3.Image = menuItemHeaderSize;
                        }

                    }

                }

            }
        }
        protected override void OnHandleCreated(EventArgs e)
        { 
            base.OnHandleCreated(e);
            if(this.DesignMode == false)
            {
                LoadMenuItemAppearance();
                this.Renderer = new MenuRenderizador(isMainMenu, primaryColor, menuItemTextColor);
            }
        }
    }
}
