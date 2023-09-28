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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/AccessingEnvironmentSettingsEnvironmentMachineNameandEnvironmentVersion.htm
    public partial  class frmAccessingEnvironmentSettingsEnvironmentMachineNameandEnvironmentVersion:Form
    {
        public frmAccessingEnvironmentSettingsEnvironmentMachineNameandEnvironmentVersion()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccessingEnvironmentSettingsEnvironmentMachineNameandEnvironmentVersion
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccessingEnvironmentSettingsEnvironmentMachineNameandEnvironmentVersion";
            this.Text = "frmAccessingEnvironmentSettingsEnvironmentMachineNameandEnvironmentVersion";
            this.Load += new System.EventHandler(this.frmAccessingEnvironmentSettingsEnvironmentMachineNameandEnvironmentVersion_Load);
            this.ResumeLayout(false);

        }

        private void frmAccessingEnvironmentSettingsEnvironmentMachineNameandEnvironmentVersion_Load(object sender, EventArgs e)
        {

        }
    }
}
