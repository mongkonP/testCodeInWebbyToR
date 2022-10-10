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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/AboutDialogBox.htm
    public partial  class frmAboutDialogBox:Form
    {
        public frmAboutDialogBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAboutDialogBox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAboutDialogBox";
            this.Text = "frmAboutDialogBox";
            this.Load += new System.EventHandler(this.frmAboutDialogBox_Load);
            this.ResumeLayout(false);

        }

        private void frmAboutDialogBox_Load(object sender, EventArgs e)
        {

        }
    }
}
