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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/CreateaPointFfromPoint.htm
    public partial  class frmCreateaPointFfromPoint:Form
    {
        public frmCreateaPointFfromPoint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateaPointFfromPoint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateaPointFfromPoint";
            this.Text = "frmCreateaPointFfromPoint";
            this.Load += new System.EventHandler(this.frmCreateaPointFfromPoint_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateaPointFfromPoint_Load(object sender, EventArgs e)
        {
            Size sz = new Size(12, 12);
            Point pt = new Point(20, 20);

            pt = pt + sz;
            MessageBox.Show("Addition :" + pt.ToString());
            pt = pt - sz;
            MessageBox.Show("Subtraction :" + pt.ToString());

            PointF ptf = pt;
            MessageBox.Show("PointF :" + pt.ToString());

            sz = (Size)pt;
            MessageBox.Show("Size :" + sz.Width.ToString()
                + "," + sz.Height.ToString());
        }
    }
}
