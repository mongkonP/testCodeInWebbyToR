using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0019__Graphics
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/DrawString.htm
    public partial  class frmDrawString:Form
    {
        public frmDrawString()
        {
            InitializeComponent();
            this.Text = "Paint Hello";
            this.BackColor = Color.White;
            this.Paint += new PaintEventHandler(MyPaintHandler);
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawString
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawString";
            this.Text = "frmDrawString";
            this.Load += new System.EventHandler(this.frmDrawString_Load);
            this.ResumeLayout(false);

        }

        private void frmDrawString_Load(object sender, EventArgs e)
        {

        }
        void MyPaintHandler(object objSender, PaintEventArgs pea)
        {
            Form form = (Form)objSender;
            Graphics graphics = pea.Graphics;

            graphics.DrawString("Hello, world!", form.Font, Brushes.Black, 0, 0);
        }
    }
}
