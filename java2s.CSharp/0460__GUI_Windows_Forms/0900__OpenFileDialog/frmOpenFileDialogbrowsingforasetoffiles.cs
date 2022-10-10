using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C0900__OpenFileDialog
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/OpenFileDialogbrowsingforasetoffiles.htm
    public partial  class frmOpenFileDialogbrowsingforasetoffiles:Form
    {
        public frmOpenFileDialogbrowsingforasetoffiles()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOpenFileDialogbrowsingforasetoffiles
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOpenFileDialogbrowsingforasetoffiles";
            this.Text = "frmOpenFileDialogbrowsingforasetoffiles";
            this.Load += new System.EventHandler(this.frmOpenFileDialogbrowsingforasetoffiles_Load);
            this.ResumeLayout(false);

        }

        private void frmOpenFileDialogbrowsingforasetoffiles_Load(object sender, EventArgs e)
        {

        }
    }
}
