using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0040__Switch
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Switchwithonlydefault.htm
    public partial  class frmSwitchwithonlydefault:Form
    {
        public frmSwitchwithonlydefault()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSwitchwithonlydefault
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSwitchwithonlydefault";
            this.Text = "frmSwitchwithonlydefault";
            this.Load += new System.EventHandler(this.frmSwitchwithonlydefault_Load);
            this.ResumeLayout(false);

        }

        private void frmSwitchwithonlydefault_Load(object sender, EventArgs e)
        {

        }
    }
}
