using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1040__Dialog
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DialogApplyEventIllustration.htm
    public partial  class frmDialogApplyEventIllustration:Form
    {
        public frmDialogApplyEventIllustration()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDialogApplyEventIllustration
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDialogApplyEventIllustration";
            this.Text = "frmDialogApplyEventIllustration";
            this.Load += new System.EventHandler(this.frmDialogApplyEventIllustration_Load);
            this.ResumeLayout(false);

        }

        private void frmDialogApplyEventIllustration_Load(object sender, EventArgs e)
        {

        }
    }
}
