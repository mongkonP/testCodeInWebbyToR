using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0060__Point
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/CreateingPoint.htm
    public partial  class frmCreateingPoint:Form
    {
        public frmCreateingPoint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateingPoint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateingPoint";
            this.Text = "frmCreateingPoint";
            this.BackColor = Color.Black;
            this.Paint += new PaintEventHandler(MyPaintHandler);
            this.Load += new System.EventHandler(this.frmCreateingPoint_Load);
           
            this.ResumeLayout(false);

        }

        private void frmCreateingPoint_Load(object sender, EventArgs e)
        {

        }
        private void MyPaintHandler(object objSender, PaintEventArgs pea)
        {
            Form form = (Form)objSender;
            Graphics g = pea.Graphics;

            Point pt = new Point(50, 50);
            Point newPoint = Point.Empty;
            newPoint.X = 100;
            newPoint.Y = 200;
            Pen pn = new Pen(Color.Blue, 4);
            g.DrawLine(pn, pt, newPoint);
            pn.Dispose();
            g.Dispose();
        }
    }
}
