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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/DisplayPrintDialog.htm
    public partial  class frmDisplayPrintDialog:Form
    {
        public frmDisplayPrintDialog()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDisplayPrintDialog
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDisplayPrintDialog";
            this.Text = "frmDisplayPrintDialog";
            this.Load += new System.EventHandler(this.frmDisplayPrintDialog_Load);
            this.ResumeLayout(false);

        }

        private void frmDisplayPrintDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
