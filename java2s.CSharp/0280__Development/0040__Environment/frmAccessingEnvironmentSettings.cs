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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/AccessingEnvironmentSettings.htm
    public partial  class frmAccessingEnvironmentSettings:Form
    {
        public frmAccessingEnvironmentSettings()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAccessingEnvironmentSettings
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAccessingEnvironmentSettings";
            this.Text = "frmAccessingEnvironmentSettings";
            this.Load += new System.EventHandler(this.frmAccessingEnvironmentSettings_Load);
            this.ResumeLayout(false);

        }

        private void frmAccessingEnvironmentSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
