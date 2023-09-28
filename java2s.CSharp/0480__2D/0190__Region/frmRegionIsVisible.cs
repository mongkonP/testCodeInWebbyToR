using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0190__Region
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/RegionIsVisible.htm
    public partial  class frmRegionIsVisible:Form
    {
        private System.Windows.Forms.Label label1;
        GraphicsPath gP;
        string mes = "Move to the big I!";
        FontFamily fF = new FontFamily("Times new roman");

        public frmRegionIsVisible()
        {
            InitializeComponent();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.label1.Location = new System.Drawing.Point(88, 16);
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.Text = "label1";
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 109);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.label1 });
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            Graphics g = this.CreateGraphics();
            label1.Text = mes;
            string s = "I";
            int fSt = (int)FontStyle.Regular;
            Point xy = new Point(50, 10);
            StringFormat sFr = StringFormat.GenericDefault;
            gP = new GraphicsPath();
            gP.AddString(s, fF, fSt, 50, xy, sFr);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRegionIsVisible
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRegionIsVisible";
            this.Text = "frmRegionIsVisible";
            this.Load += new System.EventHandler(this.frmRegionIsVisible_Load);
            this.ResumeLayout(false);

        }

        private void frmRegionIsVisible_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.DrawPath(Pens.Black, gP);  // draw the path to the surface
            g.Dispose();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Region reg = new Region(gP);
            if (reg.IsVisible(new Point(e.X, e.Y)))
                mes = "in";
            else
                mes = "Move to the big I!";

        }
    }
}
