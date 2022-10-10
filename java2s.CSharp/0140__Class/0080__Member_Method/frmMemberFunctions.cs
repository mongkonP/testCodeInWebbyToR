using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0080__Member_Method
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/MemberFunctions.htm
    public partial  class frmMemberFunctions:Form
    {
        public frmMemberFunctions()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMemberFunctions
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMemberFunctions";
            this.Text = "frmMemberFunctions";
            this.Load += new System.EventHandler(this.frmMemberFunctions_Load);
            this.ResumeLayout(false);

        }

        private void frmMemberFunctions_Load(object sender, EventArgs e)
        {

        }
    }
}
