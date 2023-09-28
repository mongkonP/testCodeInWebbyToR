using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0020__Language_Basics.C0200__ref
{
    //http://www.java2s.com/Tutorial/CSharp/0020__Language-Basics/Changestringusingrefkeyword.htm
    public partial  class frmChangestringusingrefkeyword:Form
    {
        public frmChangestringusingrefkeyword()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmChangestringusingrefkeyword
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmChangestringusingrefkeyword";
            this.Text = "frmChangestringusingrefkeyword";
            this.Load += new System.EventHandler(this.frmChangestringusingrefkeyword_Load);
            this.ResumeLayout(false);

        }

        private void frmChangestringusingrefkeyword_Load(object sender, EventArgs e)
        {

        }
    }
}
