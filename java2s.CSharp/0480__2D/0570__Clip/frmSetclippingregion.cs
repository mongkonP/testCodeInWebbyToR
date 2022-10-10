using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0570__Clip
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Setclippingregion.htm
    public partial  class frmSetclippingregion:Form
    {
        public frmSetclippingregion()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetclippingregion
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetclippingregion";
            this.Text = "frmSetclippingregion";
            this.Load += new System.EventHandler(this.frmSetclippingregion_Load);
            this.ResumeLayout(false);

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.White, this.ClientRectangle);
            GraphicsPath gp = new GraphicsPath();
            gp.AddString("Swirly", new FontFamily("Times New Roman"), (int)(FontStyle.Bold | FontStyle.Italic), 144, new Point(5, 5), StringFormat.GenericTypographic);
            g.SetClip(gp);
            g.DrawImage(new Bitmap("swirly.jpg"), this.ClientRectangle);
            gp.Dispose();
        }
        private void frmSetclippingregion_Load(object sender, EventArgs e)
        {

        }
    }
}
