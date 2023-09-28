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
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/SwitchwithoutDefault.htm
    public partial  class frmSwitchwithoutDefault:Form
    {
        public frmSwitchwithoutDefault()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSwitchwithoutDefault
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSwitchwithoutDefault";
            this.Text = "frmSwitchwithoutDefault";
            this.Load += new System.EventHandler(this.frmSwitchwithoutDefault_Load);
            this.ResumeLayout(false);

        }

        private void frmSwitchwithoutDefault_Load(object sender, EventArgs e)
        {

        }
    }
}
