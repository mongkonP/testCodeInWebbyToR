using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0560__ADO.Net.C0240__SqlConnection_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/UsingADONETEvents.htm
    public partial  class frmUsingADONETEvents:Form
    {
        public frmUsingADONETEvents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingADONETEvents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingADONETEvents";
            this.Text = "frmUsingADONETEvents";
            this.Load += new System.EventHandler(this.frmUsingADONETEvents_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingADONETEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
