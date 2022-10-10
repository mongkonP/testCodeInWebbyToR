using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0660__HelpProvider
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/UseHelpProvidertoLoadCHMfile.htm
    public partial  class frmUseHelpProvidertoLoadCHMfile:Form
    {
        public frmUseHelpProvidertoLoadCHMfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseHelpProvidertoLoadCHMfile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseHelpProvidertoLoadCHMfile";
            this.Text = "frmUseHelpProvidertoLoadCHMfile";
            this.Load += new System.EventHandler(this.frmUseHelpProvidertoLoadCHMfile_Load);
            this.ResumeLayout(false);

        }

        private void frmUseHelpProvidertoLoadCHMfile_Load(object sender, EventArgs e)
        {

        }
    }
}
