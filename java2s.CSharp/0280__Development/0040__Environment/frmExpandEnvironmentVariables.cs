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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/ExpandEnvironmentVariables.htm
    public partial  class frmExpandEnvironmentVariables:Form
    {
        public frmExpandEnvironmentVariables()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExpandEnvironmentVariables
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExpandEnvironmentVariables";
            this.Text = "frmExpandEnvironmentVariables";
            this.Load += new System.EventHandler(this.frmExpandEnvironmentVariables_Load);
            this.ResumeLayout(false);

        }

        private void frmExpandEnvironmentVariables_Load(object sender, EventArgs e)
        {

        }
    }
}
