using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0620__unsafe.C0019__unsafe
{
    //http://www.java2s.com/Tutorial/CSharp/0620__unsafe/Usingtheunsafekeyword.htm
    public partial  class frmUsingtheunsafekeyword:Form
    {
        public frmUsingtheunsafekeyword()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingtheunsafekeyword
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingtheunsafekeyword";
            this.Text = "frmUsingtheunsafekeyword";
            this.Load += new System.EventHandler(this.frmUsingtheunsafekeyword_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingtheunsafekeyword_Load(object sender, EventArgs e)
        {

        }
    }
}
