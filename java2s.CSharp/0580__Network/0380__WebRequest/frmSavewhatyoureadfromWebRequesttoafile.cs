using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0380__WebRequest
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/SavewhatyoureadfromWebRequesttoafile.htm
    public partial  class frmSavewhatyoureadfromWebRequesttoafile:Form
    {
        public frmSavewhatyoureadfromWebRequesttoafile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSavewhatyoureadfromWebRequesttoafile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSavewhatyoureadfromWebRequesttoafile";
            this.Text = "frmSavewhatyoureadfromWebRequesttoafile";
            this.Load += new System.EventHandler(this.frmSavewhatyoureadfromWebRequesttoafile_Load);
            this.ResumeLayout(false);

        }

        private void frmSavewhatyoureadfromWebRequesttoafile_Load(object sender, EventArgs e)
        {

        }
    }
}
