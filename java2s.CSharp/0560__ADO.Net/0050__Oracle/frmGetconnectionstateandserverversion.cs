using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0050__Oracle
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/Getconnectionstateandserverversion.htm
    public partial  class frmGetconnectionstateandserverversion:Form
    {
        public frmGetconnectionstateandserverversion()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetconnectionstateandserverversion
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetconnectionstateandserverversion";
            this.Text = "frmGetconnectionstateandserverversion";
            this.Load += new System.EventHandler(this.frmGetconnectionstateandserverversion_Load);
            this.ResumeLayout(false);

        }

        private void frmGetconnectionstateandserverversion_Load(object sender, EventArgs e)
        {

        }
    }
}
