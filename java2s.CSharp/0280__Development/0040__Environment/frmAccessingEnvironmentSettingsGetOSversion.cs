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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/AccessingEnvironmentSettingsGetOSversion.htm
    public partial  class frmAccessingEnvironmentSettingsGetOSversion:Form
    {
        public frmAccessingEnvironmentSettingsGetOSversion()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccessingEnvironmentSettingsGetOSversion
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccessingEnvironmentSettingsGetOSversion";
            this.Text = "frmAccessingEnvironmentSettingsGetOSversion";
            this.Load += new System.EventHandler(this.frmAccessingEnvironmentSettingsGetOSversion_Load);
            this.ResumeLayout(false);

        }

        private void frmAccessingEnvironmentSettingsGetOSversion_Load(object sender, EventArgs e)
        {

        }
    }
}
