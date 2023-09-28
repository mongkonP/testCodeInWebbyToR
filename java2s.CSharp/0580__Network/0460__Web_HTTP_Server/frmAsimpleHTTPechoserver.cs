using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0460__Web_HTTP_Server
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/AsimpleHTTPechoserver.htm
    public partial  class frmAsimpleHTTPechoserver:Form
    {
        public frmAsimpleHTTPechoserver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsimpleHTTPechoserver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsimpleHTTPechoserver";
            this.Text = "frmAsimpleHTTPechoserver";
            this.Load += new System.EventHandler(this.frmAsimpleHTTPechoserver_Load);
            this.ResumeLayout(false);

        }

        private void frmAsimpleHTTPechoserver_Load(object sender, EventArgs e)
        {

        }
    }
}
