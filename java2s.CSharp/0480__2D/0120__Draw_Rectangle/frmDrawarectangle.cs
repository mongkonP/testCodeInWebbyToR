using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0120__Draw_Rectangle
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Drawarectangle.htm
    public partial  class frmDrawarectangle:Form
    {
        public frmDrawarectangle()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawarectangle
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawarectangle";
            this.Text = "frmDrawarectangle";
            this.Load += new System.EventHandler(this.frmDrawarectangle_Load);
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 400);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DrawARectangle_Paint);
            this.ResumeLayout(false);

        }

        private void frmDrawarectangle_Load(object sender, EventArgs e)
        {

        }
        private void DrawARectangle_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen p = new Pen(Color.Black, 5);
            g.DrawRectangle(p, 10, 10, 200, 200);
        }
    }
}
