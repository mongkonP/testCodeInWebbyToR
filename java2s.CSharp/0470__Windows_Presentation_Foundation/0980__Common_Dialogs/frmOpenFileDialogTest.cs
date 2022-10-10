using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0980__Common_Dialogs
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/OpenFileDialogTest.htm
    public partial  class frmOpenFileDialogTest:Form
    {
        public frmOpenFileDialogTest()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmOpenFileDialogTest
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmOpenFileDialogTest";
            this.Text = "frmOpenFileDialogTest";
            this.Load += new System.EventHandler(this.frmOpenFileDialogTest_Load);
            this.ResumeLayout(false);

        }

        private void frmOpenFileDialogTest_Load(object sender, EventArgs e)
        {

        }
    }
}
