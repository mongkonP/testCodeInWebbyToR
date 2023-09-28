using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0280__Development.C0460__BooleanSwitch
{
    //http://www.java2s.com/Tutorial/CSharp/0280__Development/UsingBooleanSwitch.htm
    public partial  class frmUsingBooleanSwitch:Form
    {
        public frmUsingBooleanSwitch()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingBooleanSwitch
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingBooleanSwitch";
            this.Text = "frmUsingBooleanSwitch";
            this.Load += new System.EventHandler(this.frmUsingBooleanSwitch_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingBooleanSwitch_Load(object sender, EventArgs e)
        {

        }
    }
}
