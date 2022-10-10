using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0160__richTextBox1_window_settings
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/CleararichTextBox1.htm
    public partial  class frmCleararichTextBox1:Form
    {
        public frmCleararichTextBox1()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCleararichTextBox1
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCleararichTextBox1";
            this.Text = "frmCleararichTextBox1";
            this.Load += new System.EventHandler(this.frmCleararichTextBox1_Load);
            this.ResumeLayout(false);

        }

        private void frmCleararichTextBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
