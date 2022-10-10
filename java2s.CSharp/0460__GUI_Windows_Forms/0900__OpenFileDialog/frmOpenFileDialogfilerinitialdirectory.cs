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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/OpenFileDialogfilerinitialdirectory.htm
    public partial  class frmOpenFileDialogfilerinitialdirectory:Form
    {
        public frmOpenFileDialogfilerinitialdirectory()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOpenFileDialogfilerinitialdirectory
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOpenFileDialogfilerinitialdirectory";
            this.Text = "frmOpenFileDialogfilerinitialdirectory";
            this.Load += new System.EventHandler(this.frmOpenFileDialogfilerinitialdirectory_Load);
            this.ResumeLayout(false);

        }

        private void frmOpenFileDialogfilerinitialdirectory_Load(object sender, EventArgs e)
        {

        }
    }
}
