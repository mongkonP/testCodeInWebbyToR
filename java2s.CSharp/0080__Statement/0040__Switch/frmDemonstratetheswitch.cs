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
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Demonstratetheswitch.htm
    public partial  class frmDemonstratetheswitch:Form
    {
        public frmDemonstratetheswitch()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstratetheswitch
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstratetheswitch";
            this.Text = "frmDemonstratetheswitch";
            this.Load += new System.EventHandler(this.frmDemonstratetheswitch_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstratetheswitch_Load(object sender, EventArgs e)
        {

        }
    }
}
