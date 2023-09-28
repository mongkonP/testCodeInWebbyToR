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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/AccessingEnvironmentSettingsEnvironmentVariables.htm
    public partial  class frmAccessingEnvironmentSettingsEnvironmentVariables:Form
    {
        public frmAccessingEnvironmentSettingsEnvironmentVariables()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccessingEnvironmentSettingsEnvironmentVariables
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccessingEnvironmentSettingsEnvironmentVariables";
            this.Text = "frmAccessingEnvironmentSettingsEnvironmentVariables";
            this.Load += new System.EventHandler(this.frmAccessingEnvironmentSettingsEnvironmentVariables_Load);
            this.ResumeLayout(false);

        }

        private void frmAccessingEnvironmentSettingsEnvironmentVariables_Load(object sender, EventArgs e)
        {

        }
    }
}
