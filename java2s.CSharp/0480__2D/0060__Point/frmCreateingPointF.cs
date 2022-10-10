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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/CreateingPointF.htm
    public partial  class frmCreateingPointF:Form
    {
        public frmCreateingPointF()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateingPointF
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateingPointF";
            this.Text = "frmCreateingPointF";
            this.BackColor = Color.Black;
            this.Paint += new PaintEventHandler(MyPaintHandler);
            this.Load += new System.EventHandler(this.frmCreateingPointF_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateingPointF_Load(object sender, EventArgs e)
        {

        }
        void MyPaintHandler(object objSender, PaintEventArgs pea)
        {
            Form form = (Form)objSender;
            Graphics g = pea.Graphics;

            PointF pt = new PointF(50.0F, 50.0F);
            PointF newPoint = PointF.Empty;
            newPoint.X = 100.0F;
            newPoint.Y = 200.0F;

            Pen pn = new Pen(Color.Blue, 4);
            g.DrawLine(pn, pt, newPoint);
            pn.Dispose();
            g.Dispose();


        }
    }
}
