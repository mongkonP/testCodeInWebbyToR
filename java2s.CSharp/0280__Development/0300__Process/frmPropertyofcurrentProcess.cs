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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/PropertyofcurrentProcess.htm
    public partial  class frmPropertyofcurrentProcess:Form
    {
        public frmPropertyofcurrentProcess()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPropertyofcurrentProcess
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPropertyofcurrentProcess";
            this.Text = "frmPropertyofcurrentProcess";
            this.Load += new System.EventHandler(this.frmPropertyofcurrentProcess_Load);
            this.ResumeLayout(false);

        }

        private void frmPropertyofcurrentProcess_Load(object sender, EventArgs e)
        {

        }
    }
}
