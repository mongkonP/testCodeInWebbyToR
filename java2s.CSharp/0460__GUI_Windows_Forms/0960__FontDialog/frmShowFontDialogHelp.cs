using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0960__FontDialog
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/ShowFontDialogHelp.htm
    public partial  class frmShowFontDialogHelp:Form
    {
        public frmShowFontDialogHelp()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShowFontDialogHelp
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShowFontDialogHelp";
            this.Text = "frmShowFontDialogHelp";
            this.Load += new System.EventHandler(this.frmShowFontDialogHelp_Load);
            this.ResumeLayout(false);

        }

        private void frmShowFontDialogHelp_Load(object sender, EventArgs e)
        {

        }
    }
}
