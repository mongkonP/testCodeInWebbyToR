using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0860__Bitwise_OR
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/bitwiseexclusiveOR.htm
    public partial  class frmbitwiseexclusiveOR:Form
    {
        public frmbitwiseexclusiveOR()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmbitwiseexclusiveOR
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmbitwiseexclusiveOR";
            this.Text = "frmbitwiseexclusiveOR";
            this.Load += new System.EventHandler(this.frmbitwiseexclusiveOR_Load);
            this.ResumeLayout(false);

        }

        private void frmbitwiseexclusiveOR_Load(object sender, EventArgs e)
        {

        }
    }
}
