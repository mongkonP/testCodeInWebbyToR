using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0200__this
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Invokeaconstructorthroughthis.htm
    public partial  class frmInvokeaconstructorthroughthis:Form
    {
        public frmInvokeaconstructorthroughthis()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInvokeaconstructorthroughthis
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInvokeaconstructorthroughthis";
            this.Text = "frmInvokeaconstructorthroughthis";
            this.Load += new System.EventHandler(this.frmInvokeaconstructorthroughthis_Load);
            this.ResumeLayout(false);

        }

        private void frmInvokeaconstructorthroughthis_Load(object sender, EventArgs e)
        {

        }
    }
}
