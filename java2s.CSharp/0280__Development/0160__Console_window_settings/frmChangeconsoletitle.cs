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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/ChangerichTextBox1title.htm
    public partial  class frmChangerichTextBox1title:Form
    {
        public frmChangerichTextBox1title()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangerichTextBox1title
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangerichTextBox1title";
            this.Text = "frmChangerichTextBox1title";
            this.Load += new System.EventHandler(this.frmChangerichTextBox1title_Load);
            this.ResumeLayout(false);

        }

        private void frmChangerichTextBox1title_Load(object sender, EventArgs e)
        {

        }
    }
}
