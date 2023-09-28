using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0040__Environment
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/AccessingEnvironmentSettingsEnvironmentStackTrace.htm
    public partial  class frmAccessingEnvironmentSettingsEnvironmentStackTrace:Form
    {
        public frmAccessingEnvironmentSettingsEnvironmentStackTrace()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccessingEnvironmentSettingsEnvironmentStackTrace
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccessingEnvironmentSettingsEnvironmentStackTrace";
            this.Text = "frmAccessingEnvironmentSettingsEnvironmentStackTrace";
            this.Load += new System.EventHandler(this.frmAccessingEnvironmentSettingsEnvironmentStackTrace_Load);
            this.ResumeLayout(false);

        }

        private void frmAccessingEnvironmentSettingsEnvironmentStackTrace_Load(object sender, EventArgs e)
        {

        }
    }
}
