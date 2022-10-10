using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0480__2D.C0420__Pens
{
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/AllLineCapDemo.htm
    public partial  class frmAllLineCapDemo:Form
    {
        private System.ComponentModel.Container components = null;

        public frmAllLineCapDemo()
        {
            InitializeComponent();
        }
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

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAllLineCapDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAllLineCapDemo";
            this.Text = "frmAllLineCapDemo";
            this.Load += new System.EventHandler(this.frmAllLineCapDemo_Load);
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Resize += new System.EventHandler(this.LineCapDemo_Resize);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LineCapDemo_Paint);
            this.ResumeLayout(false);

        }
        private void LineCapDemo_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen thePen = new Pen(Color.Black, 10);
            int yOffSet = 10;

            Array obj = Enum.GetValues(typeof(LineCap));

            for (int x = 0; x < obj.Length; x++)
            {
                LineCap temp = (LineCap)obj.GetValue(x);
                thePen.StartCap = temp;
                thePen.EndCap = temp;

                g.DrawString(temp.ToString(), new Font("Times New Roman", 10), new SolidBrush(Color.Black), 0, yOffSet);
                g.DrawLine(thePen, 100, yOffSet, Width - 50, yOffSet);
                yOffSet += 40;
            }
        }

        private void LineCapDemo_Resize(object sender, System.EventArgs e)
        {
            Invalidate();
        }
        private void frmAllLineCapDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
