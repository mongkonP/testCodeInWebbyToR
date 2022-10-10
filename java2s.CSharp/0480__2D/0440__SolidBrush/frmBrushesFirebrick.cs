using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0440__SolidBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/BrushesFirebrick.htm
    public partial  class frmBrushesFirebrick:Form
    {
        private System.ComponentModel.Container components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        public frmBrushesFirebrick()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBrushesFirebrick
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBrushesFirebrick";
            this.Text = "frmBrushesFirebrick";
            this.Load += new System.EventHandler(this.frmBrushesFirebrick_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Text = "Solid Brushes...";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }
        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            SolidBrush pen = (SolidBrush)Brushes.Firebrick;

            g.FillEllipse(pen, 10, 10, 100, 100);
        }
        private void frmBrushesFirebrick_Load(object sender, EventArgs e)
        {

        }
    }
}
