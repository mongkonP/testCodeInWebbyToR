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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/AccessingEnvironmentSettingsLogicalDrives.htm
    public partial  class frmAccessingEnvironmentSettingsLogicalDrives:Form
    {
        public frmAccessingEnvironmentSettingsLogicalDrives()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccessingEnvironmentSettingsLogicalDrives
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccessingEnvironmentSettingsLogicalDrives";
            this.Text = "frmAccessingEnvironmentSettingsLogicalDrives";
            this.Load += new System.EventHandler(this.frmAccessingEnvironmentSettingsLogicalDrives_Load);
            this.ResumeLayout(false);

        }

        private void frmAccessingEnvironmentSettingsLogicalDrives_Load(object sender, EventArgs e)
        {

        }
    }
}
