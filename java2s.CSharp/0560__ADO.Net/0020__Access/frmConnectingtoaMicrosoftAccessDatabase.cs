using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0020__Access
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ConnectingtoaMicrosoftAccessDatabase.htm
    public partial  class frmConnectingtoaMicrosoftAccessDatabase:Form
    {
        public frmConnectingtoaMicrosoftAccessDatabase()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmConnectingtoaMicrosoftAccessDatabase
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmConnectingtoaMicrosoftAccessDatabase";
            this.Text = "frmConnectingtoaMicrosoftAccessDatabase";
            this.Load += new System.EventHandler(this.frmConnectingtoaMicrosoftAccessDatabase_Load);
            this.ResumeLayout(false);

        }

        private void frmConnectingtoaMicrosoftAccessDatabase_Load(object sender, EventArgs e)
        {

        }
    }
}
