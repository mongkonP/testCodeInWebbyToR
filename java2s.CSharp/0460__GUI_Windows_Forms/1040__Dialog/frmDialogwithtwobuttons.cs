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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Dialogwithtwobuttons.htm
    public partial  class frmDialogwithtwobuttons:Form
    {
        public frmDialogwithtwobuttons()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDialogwithtwobuttons
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDialogwithtwobuttons";
            this.Text = "frmDialogwithtwobuttons";
            this.Load += new System.EventHandler(this.frmDialogwithtwobuttons_Load);
            this.ResumeLayout(false);

        }

        private void frmDialogwithtwobuttons_Load(object sender, EventArgs e)
        {

        }
    }
}
