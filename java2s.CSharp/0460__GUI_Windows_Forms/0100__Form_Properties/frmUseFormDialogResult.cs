using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0100__Form_Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/UseFormDialogResult.htm
    public partial  class frmUseFormDialogResult:Form
    {
        public frmUseFormDialogResult()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseFormDialogResult
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseFormDialogResult";
            this.Text = "frmUseFormDialogResult";
            this.Load += new System.EventHandler(this.frmUseFormDialogResult_Load);
            this.ResumeLayout(false);

        }

        private void frmUseFormDialogResult_Load(object sender, EventArgs e)
        {

        }
    }
}
