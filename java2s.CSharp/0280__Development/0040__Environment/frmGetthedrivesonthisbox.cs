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
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/Getthedrivesonthisbox.htm
    public partial  class frmGetthedrivesonthisbox:Form
    {
        public frmGetthedrivesonthisbox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetthedrivesonthisbox
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetthedrivesonthisbox";
            this.Text = "frmGetthedrivesonthisbox";
            this.Load += new System.EventHandler(this.frmGetthedrivesonthisbox_Load);
            this.ResumeLayout(false);

        }

        private void frmGetthedrivesonthisbox_Load(object sender, EventArgs e)
        {

        }
    }
}
