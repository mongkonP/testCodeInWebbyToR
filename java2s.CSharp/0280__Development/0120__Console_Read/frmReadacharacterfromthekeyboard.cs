using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0120__richTextBox1_Read
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Readacharacterfromthekeyboard.htm
    public partial  class frmReadacharacterfromthekeyboard:Form
    {
        public frmReadacharacterfromthekeyboard()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReadacharacterfromthekeyboard
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReadacharacterfromthekeyboard";
            this.Text = "frmReadacharacterfromthekeyboard";
            this.Load += new System.EventHandler(this.frmReadacharacterfromthekeyboard_Load);
            this.ResumeLayout(false);

        }

        private void frmReadacharacterfromthekeyboard_Load(object sender, EventArgs e)
        {

        }
    }
}
