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
    //http://www.java2s.com/Tutorial/CSharp/0560__ADO.Net/ListentoConnectionstatechangedevent.htm
    public partial  class frmListentoConnectionstatechangedevent:Form
    {
        public frmListentoConnectionstatechangedevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmListentoConnectionstatechangedevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmListentoConnectionstatechangedevent";
            this.Text = "frmListentoConnectionstatechangedevent";
            this.Load += new System.EventHandler(this.frmListentoConnectionstatechangedevent_Load);
            this.ResumeLayout(false);

        }

        private void frmListentoConnectionstatechangedevent_Load(object sender, EventArgs e)
        {

        }
    }
}
