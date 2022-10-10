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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Subtractpointandsize.htm
    public partial  class frmSubtractpointandsize:Form
    {
        public frmSubtractpointandsize()
        {
            InitializeComponent();
        }
        private RichTextBox richTextBox1;
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(756, 454);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // frmSubtractpointandsize
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmSubtractpointandsize";
            this.Text = "frmSubtractpointandsize";
            this.Load += new System.EventHandler(this.frmSubtractpointandsize_Load);
            this.ResumeLayout(false);

        }

        private void frmSubtractpointandsize_Load(object sender, EventArgs e)
        {
            Size sz = new Size(12, 12);
            Point pt = new Point(20, 20);

            pt = pt + sz;
            richTextBox1.WriteLine("Addition :" + pt.ToString());
            pt = pt - sz;
            richTextBox1.WriteLine("Subtraction :" + pt.ToString());

            PointF ptf = pt;
            richTextBox1.WriteLine("PointF :" + pt.ToString());

            sz = (Size)pt;
            richTextBox1.WriteLine("Size :" + sz.Width.ToString() + "," + sz.Height.ToString());
        }
    }
}
