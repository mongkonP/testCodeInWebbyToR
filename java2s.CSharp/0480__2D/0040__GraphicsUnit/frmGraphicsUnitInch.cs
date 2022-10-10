using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0040__GraphicsUnit
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/GraphicsUnitInch.htm
    public partial  class frmGraphicsUnitInch:Form
    {
        public frmGraphicsUnitInch()
        {
            InitializeComponent();
            ResizeRedraw = true;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGraphicsUnitInch
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGraphicsUnitInch";
            this.Text = "frmGraphicsUnitInch";
            this.Load += new System.EventHandler(this.frmGraphicsUnitInch_Load);
            this.ResumeLayout(false);

        }

        private void frmGraphicsUnitInch_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs pea)
        {
            DoPage(pea.Graphics, ForeColor, ClientSize.Width, ClientSize.Height);
        }
        protected void DoPage(Graphics grfx, Color clr, int cx, int cy)
        {
            Brush brush = new SolidBrush(clr);
            int y = 0;

            DoIt(grfx, brush, ref y, GraphicsUnit.Inch);
        }
        void DoIt(Graphics grfx, Brush brush, ref int y, GraphicsUnit gu)
        {
            GraphicsState gs = grfx.Save();

            grfx.PageUnit = gu;
            grfx.PageScale = 1;

            SizeF sizef = grfx.VisibleClipBounds.Size;

            grfx.Restore(gs);

            grfx.DrawString(gu + ": " + sizef, Font, brush, 0, y);
            y += (int)Math.Ceiling(Font.GetHeight(grfx));
        }
    }
}
