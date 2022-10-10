using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0060__richTextBox1_Output
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/WriteLine.htm
    public partial  class frmWriteLine:Form
    {
        public frmWriteLine()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWriteLine
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWriteLine";
            this.Text = "frmWriteLine";
            this.Load += new System.EventHandler(this.frmWriteLine_Load);
            this.ResumeLayout(false);

        }

        private void frmWriteLine_Load(object sender, EventArgs e)
        {

        }
    }
}
