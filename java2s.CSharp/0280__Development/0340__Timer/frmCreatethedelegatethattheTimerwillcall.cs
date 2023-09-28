using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0340__Timer
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/CreatethedelegatethattheTimerwillcall.htm
    public partial  class frmCreatethedelegatethattheTimerwillcall:Form
    {
        public frmCreatethedelegatethattheTimerwillcall()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatethedelegatethattheTimerwillcall
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatethedelegatethattheTimerwillcall";
            this.Text = "frmCreatethedelegatethattheTimerwillcall";
            this.Load += new System.EventHandler(this.frmCreatethedelegatethattheTimerwillcall_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatethedelegatethattheTimerwillcall_Load(object sender, EventArgs e)
        {

        }
    }
}
