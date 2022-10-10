using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0040__Data_Type.C0740__enum_switch
{
    //http://www.java2s.com/Tutorial/CSharp/0040__Data-Type/Switchwithenum.htm
    public partial  class frmSwitchwithenum:Form
    {
        public frmSwitchwithenum()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSwitchwithenum
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSwitchwithenum";
            this.Text = "frmSwitchwithenum";
            this.Load += new System.EventHandler(this.frmSwitchwithenum_Load);
            this.ResumeLayout(false);

        }

        private void frmSwitchwithenum_Load(object sender, EventArgs e)
        {

        }
    }
}
