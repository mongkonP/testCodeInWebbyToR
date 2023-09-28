using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0320__ProcessStartInfo
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/CreateProcessStartInfo.htm
    public partial  class frmCreateProcessStartInfo:Form
    {
        public frmCreateProcessStartInfo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreateProcessStartInfo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreateProcessStartInfo";
            this.Text = "frmCreateProcessStartInfo";
            this.Load += new System.EventHandler(this.frmCreateProcessStartInfo_Load);
            this.ResumeLayout(false);

        }

        private void frmCreateProcessStartInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
