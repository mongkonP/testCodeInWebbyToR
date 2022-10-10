using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0340__Preprocessing_Directives.C0140__warning
{
    //http://www.java2s.com/Tutorial/CSharp/0340__Preprocessing-Directives/UnusedWarningWithWarningSuppressed.htm
    public partial  class frmUnusedWarningWithWarningSuppressed:Form
    {
        public frmUnusedWarningWithWarningSuppressed()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUnusedWarningWithWarningSuppressed
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUnusedWarningWithWarningSuppressed";
            this.Text = "frmUnusedWarningWithWarningSuppressed";
            this.Load += new System.EventHandler(this.frmUnusedWarningWithWarningSuppressed_Load);
            this.ResumeLayout(false);

        }

        private void frmUnusedWarningWithWarningSuppressed_Load(object sender, EventArgs e)
        {

        }
    }
}
