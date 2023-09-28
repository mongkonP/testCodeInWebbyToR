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
    //http://www.java2s.com/Tutorial/CSharp/0480__2D/Createandoffsetapoint.htm
    public partial  class frmCreateandoffsetapoint:Form
    {
        private RichTextBox richTextBox1;

        public frmCreateandoffsetapoint()
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
            // frmCreateandoffsetapoint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Controls.Add(this.richTextBox1);
            this.Name = "frmCreateandoffsetapoint";
            this.Text = "frmCreateandoffsetapoint";
            this.Load += new System.EventHandler(this.frmCreateandoffsetapoint_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateandoffsetapoint_Load(object sender, EventArgs e)
        {
            Point pt = new Point(100, 72);
            richTextBox1 .WriteLine(pt);
            pt.Offset(20, 20);
            richTextBox1.WriteLine(pt);
        }
    }
}
