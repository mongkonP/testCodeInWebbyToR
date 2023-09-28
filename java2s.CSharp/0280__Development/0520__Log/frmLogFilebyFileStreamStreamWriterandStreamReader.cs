using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0520__Log
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/LogFilebyFileStreamStreamWriterandStreamReader.htm
    public partial  class frmLogFilebyFileStreamStreamWriterandStreamReader:Form
    {
        public frmLogFilebyFileStreamStreamWriterandStreamReader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLogFilebyFileStreamStreamWriterandStreamReader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLogFilebyFileStreamStreamWriterandStreamReader";
            this.Text = "frmLogFilebyFileStreamStreamWriterandStreamReader";
            this.Load += new System.EventHandler(this.frmLogFilebyFileStreamStreamWriterandStreamReader_Load);
            this.ResumeLayout(false);

        }

        private void frmLogFilebyFileStreamStreamWriterandStreamReader_Load(object sender, EventArgs e)
        {

        }
    }
}
