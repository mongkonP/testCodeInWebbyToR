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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/FillaRectanglewithablueBrush.htm
    public partial  class frmFillaRectanglewithablueBrush:Form
    {
        public frmFillaRectanglewithablueBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFillaRectanglewithablueBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFillaRectanglewithablueBrush";
            this.Text = "frmFillaRectanglewithablueBrush";
            this.Load += new System.EventHandler(this.frmFillaRectanglewithablueBrush_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Text = "Solid Brushes...";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }
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
        private void Form1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle r = new Rectangle(150, 10, 130, 60);
            g.FillRectangle(Brushes.Blue, r);
        }
        private void frmFillaRectanglewithablueBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
