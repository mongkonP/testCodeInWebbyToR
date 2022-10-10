using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0540__double_parse
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Readdoublefromkeyboardandparseit.htm
    public partial  class frmReaddoublefromkeyboardandparseit:Form
    {
        public frmReaddoublefromkeyboardandparseit()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmReaddoublefromkeyboardandparseit
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmReaddoublefromkeyboardandparseit";
            this.Text = "frmReaddoublefromkeyboardandparseit";
            this.Load += new System.EventHandler(this.frmReaddoublefromkeyboardandparseit_Load);
            this.ResumeLayout(false);

        }

        private void frmReaddoublefromkeyboardandparseit_Load(object sender, EventArgs e)
        {

        }
    }
}
