using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0300__File_Directory_Stream.C0400__StreamReader
{
    //http://www.java2s.com/Tutorial/CSharp/0300__File-Directory-Stream/UseStreamReadertoreadalinefromatextfile.htm
    public partial  class frmUseStreamReadertoreadalinefromatextfile:Form
    {
        public frmUseStreamReadertoreadalinefromatextfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseStreamReadertoreadalinefromatextfile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseStreamReadertoreadalinefromatextfile";
            this.Text = "frmUseStreamReadertoreadalinefromatextfile";
            this.Load += new System.EventHandler(this.frmUseStreamReadertoreadalinefromatextfile_Load);
            this.ResumeLayout(false);

        }

        private void frmUseStreamReadertoreadalinefromatextfile_Load(object sender, EventArgs e)
        {

        }
    }
}
