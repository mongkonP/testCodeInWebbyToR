using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0140__Delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/GetsetprivatefieldusingInvokeMember.htm
    public partial  class frmGetsetprivatefieldusingInvokeMember:Form
    {
        public frmGetsetprivatefieldusingInvokeMember()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetsetprivatefieldusingInvokeMember
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetsetprivatefieldusingInvokeMember";
            this.Text = "frmGetsetprivatefieldusingInvokeMember";
            this.Load += new System.EventHandler(this.frmGetsetprivatefieldusingInvokeMember_Load);
            this.ResumeLayout(false);

        }

        private void frmGetsetprivatefieldusingInvokeMember_Load(object sender, EventArgs e)
        {

        }
    }
}
