using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0980__PrintDialog
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/PromptPrintDialog.htm
    public partial  class frmPromptPrintDialog:Form
    {
        public frmPromptPrintDialog()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPromptPrintDialog
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPromptPrintDialog";
            this.Text = "frmPromptPrintDialog";
            this.Load += new System.EventHandler(this.frmPromptPrintDialog_Load);
            this.ResumeLayout(false);

        }

        private void frmPromptPrintDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
