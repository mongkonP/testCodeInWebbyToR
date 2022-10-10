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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Readuserselectionfromkeyboard.htm
    public partial  class frmReaduserselectionfromkeyboard:Form
    {
        public frmReaduserselectionfromkeyboard()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReaduserselectionfromkeyboard
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReaduserselectionfromkeyboard";
            this.Text = "frmReaduserselectionfromkeyboard";
            this.Load += new System.EventHandler(this.frmReaduserselectionfromkeyboard_Load);
            this.ResumeLayout(false);

        }

        private void frmReaduserselectionfromkeyboard_Load(object sender, EventArgs e)
        {

        }
    }
}
