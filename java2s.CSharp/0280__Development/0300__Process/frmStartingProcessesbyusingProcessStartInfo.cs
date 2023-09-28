using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0300__Process
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/StartingProcessesbyusingProcessStartInfo.htm
    public partial  class frmStartingProcessesbyusingProcessStartInfo:Form
    {
        public frmStartingProcessesbyusingProcessStartInfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStartingProcessesbyusingProcessStartInfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStartingProcessesbyusingProcessStartInfo";
            this.Text = "frmStartingProcessesbyusingProcessStartInfo";
            this.Load += new System.EventHandler(this.frmStartingProcessesbyusingProcessStartInfo_Load);
            this.ResumeLayout(false);

        }

        private void frmStartingProcessesbyusingProcessStartInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
