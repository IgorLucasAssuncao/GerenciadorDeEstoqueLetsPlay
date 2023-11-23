using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Controls;


namespace Gerenciador_de_estoque
{
    public class MenuRenderizador : ToolStripProfessionalRenderer
    {
        //Atributos
        private Color corPrimaria;
        private Color corDoTexto;
        private int tamanhoDaSeta;

        //Constructor
        public MenuRenderizador(bool isMainMenu, Color primarycolor, Color textcolor) : base(new TabelaDeCoresDoMenu(isMainMenu, primarycolor))
        {
            corPrimaria = primarycolor;
            corDoTexto = textcolor;
            if (isMainMenu)
            {
                tamanhoDaSeta = 2;
            }
            else
            {
                tamanhoDaSeta = 1;
            }
        }
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            base.OnRenderItemText(e);
            e.Item.ForeColor = e.Item.Selected ? corDoTexto : Color.White;
        }

        protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e)
        {
           
            //Fields
            var graph = e.Graphics;
            var arrowSize = new Size(12, 20);
            var arrowColor = e.Item.Selected ? corPrimaria : Color.White;
            var rect = new Rectangle(e.ArrowRectangle.Location.X, (e.ArrowRectangle.Height-arrowSize.Height)/2, 
                arrowSize.Width, arrowSize.Height);
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(arrowColor, tamanhoDaSeta))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rect.Left, rect.Top, rect.Right, rect.Top + rect.Height/2);
                path.AddLine(rect.Right, rect.Top + rect.Height/2, rect.Left, rect.Top+ rect.Height);
                graph.DrawPath(pen, path);
            }
           
        }

    }
}
