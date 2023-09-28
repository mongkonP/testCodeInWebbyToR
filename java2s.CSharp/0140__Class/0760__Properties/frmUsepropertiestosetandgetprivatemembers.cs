using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0760__Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Usepropertiestosetandgetprivatemembers.htm
    public partial  class frmUsepropertiestosetandgetprivatemembers:Form
    {
        public frmUsepropertiestosetandgetprivatemembers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsepropertiestosetandgetprivatemembers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsepropertiestosetandgetprivatemembers";
            this.Text = "frmUsepropertiestosetandgetprivatemembers";
            this.Load += new System.EventHandler(this.frmUsepropertiestosetandgetprivatemembers_Load);
            this.ResumeLayout(false);

        }

        private void frmUsepropertiestosetandgetprivatemembers_Load(object sender, EventArgs e)
        {

        }
    }
}
