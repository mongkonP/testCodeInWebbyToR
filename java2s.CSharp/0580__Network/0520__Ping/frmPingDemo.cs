using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0520__Ping
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/PingDemo.htm
    public partial  class frmPingDemo:Form
    {
        public frmPingDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPingDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPingDemo";
            this.Text = "frmPingDemo";
            this.Load += new System.EventHandler(this.frmPingDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmPingDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
