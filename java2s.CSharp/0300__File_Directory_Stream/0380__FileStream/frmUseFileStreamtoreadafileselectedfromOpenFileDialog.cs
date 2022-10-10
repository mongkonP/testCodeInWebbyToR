using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0380__FileStream
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/UseFileStreamtoreadafileselectedfromOpenFileDialog.htm
    public partial  class frmUseFileStreamtoreadafileselectedfromOpenFileDialog:Form
    {
        public frmUseFileStreamtoreadafileselectedfromOpenFileDialog()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseFileStreamtoreadafileselectedfromOpenFileDialog
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseFileStreamtoreadafileselectedfromOpenFileDialog";
            this.Text = "frmUseFileStreamtoreadafileselectedfromOpenFileDialog";
            this.Load += new System.EventHandler(this.frmUseFileStreamtoreadafileselectedfromOpenFileDialog_Load);
            this.ResumeLayout(false);

        }

        private void frmUseFileStreamtoreadafileselectedfromOpenFileDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
