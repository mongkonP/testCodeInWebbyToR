using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0220__config_file
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Loadconfigfile.htm
    public partial  class frmLoadconfigfile:Form
    {
        public frmLoadconfigfile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadconfigfile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadconfigfile";
            this.Text = "frmLoadconfigfile";
            this.Load += new System.EventHandler(this.frmLoadconfigfile_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadconfigfile_Load(object sender, EventArgs e)
        {

        }
    }
}
