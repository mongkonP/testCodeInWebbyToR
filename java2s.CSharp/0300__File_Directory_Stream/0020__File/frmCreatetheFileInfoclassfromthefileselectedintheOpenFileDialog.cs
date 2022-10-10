using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0020__File
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/CreatetheFileInfoclassfromthefileselectedintheOpenFileDialog.htm
    public partial  class frmCreatetheFileInfoclassfromthefileselectedintheOpenFileDialog:Form
    {
        public frmCreatetheFileInfoclassfromthefileselectedintheOpenFileDialog()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatetheFileInfoclassfromthefileselectedintheOpenFileDialog
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatetheFileInfoclassfromthefileselectedintheOpenFileDialog";
            this.Text = "frmCreatetheFileInfoclassfromthefileselectedintheOpenFileDialog";
            this.Load += new System.EventHandler(this.frmCreatetheFileInfoclassfromthefileselectedintheOpenFileDialog_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatetheFileInfoclassfromthefileselectedintheOpenFileDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
