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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/OpenFileDialogEventFileOk.htm
    public partial  class frmOpenFileDialogEventFileOk:Form
    {
        public frmOpenFileDialogEventFileOk()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOpenFileDialogEventFileOk
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOpenFileDialogEventFileOk";
            this.Text = "frmOpenFileDialogEventFileOk";
            this.Load += new System.EventHandler(this.frmOpenFileDialogEventFileOk_Load);
            this.ResumeLayout(false);

        }

        private void frmOpenFileDialogEventFileOk_Load(object sender, EventArgs e)
        {

        }
    }
}
