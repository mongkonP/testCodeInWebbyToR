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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/AccessingEnvironmentSettingsEnvironmentCurrentDirectoryandSystemDirectory.htm
    public partial  class frmAccessingEnvironmentSettingsEnvironmentCurrentDirectoryandSystemDirectory:Form
    {
        public frmAccessingEnvironmentSettingsEnvironmentCurrentDirectoryandSystemDirectory()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccessingEnvironmentSettingsEnvironmentCurrentDirectoryandSystemDirectory
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccessingEnvironmentSettingsEnvironmentCurrentDirectoryandSystemDirectory";
            this.Text = "frmAccessingEnvironmentSettingsEnvironmentCurrentDirectoryandSystemDirectory";
            this.Load += new System.EventHandler(this.frmAccessingEnvironmentSettingsEnvironmentCurrentDirectoryandSystemDirectory_Load);
            this.ResumeLayout(false);

        }

        private void frmAccessingEnvironmentSettingsEnvironmentCurrentDirectoryandSystemDirectory_Load(object sender, EventArgs e)
        {

        }
    }
}
