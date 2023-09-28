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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/OverloadedPointoperators.htm
    public partial  class frmOverloadedPointoperators:Form
    {
        private RichTextBox richTextBox1;

        public frmOverloadedPointoperators()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(756, 454);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // frmOverloadedPointoperators
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmOverloadedPointoperators";
            this.Text = "frmOverloadedPointoperators";
            this.Load += new System.EventHandler(this.frmOverloadedPointoperators_Load);
            this.ResumeLayout(false);

        }

        private void frmOverloadedPointoperators_Load(object sender, EventArgs e)
        {
            Point pt = new Point(100, 72);
            richTextBox1.WriteLine(pt);

            Point pt2 = pt;
            if (pt == pt2)
                richTextBox1 .WriteLine("Points are the same");
            else
                richTextBox1.WriteLine("Different points");
        }
    }
}
