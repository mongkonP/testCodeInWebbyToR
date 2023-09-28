using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1022__Dialog
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AboutDialog.htm
    public partial  class frmAboutDialog:Form
    {
        public frmAboutDialog()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAboutDialog
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAboutDialog";
            this.Text = "frmAboutDialog";
            this.Load += new System.EventHandler(this.frmAboutDialog_Load);
            this.ResumeLayout(false);

        }

        private void frmAboutDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
