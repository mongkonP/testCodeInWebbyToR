using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0180__Object_Send_Receive
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/ObjectdatasenderReceiver.htm
    public partial  class frmObjectdatasenderReceiver:Form
    {
        public frmObjectdatasenderReceiver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmObjectdatasenderReceiver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmObjectdatasenderReceiver";
            this.Text = "frmObjectdatasenderReceiver";
            this.Load += new System.EventHandler(this.frmObjectdatasenderReceiver_Load);
            this.ResumeLayout(false);

        }

        private void frmObjectdatasenderReceiver_Load(object sender, EventArgs e)
        {

        }
    }
}
