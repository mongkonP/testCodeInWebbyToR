using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0360__WebClient
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/ResponseHeaders.htm
    public partial  class frmResponseHeaders:Form
    {
        public frmResponseHeaders()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmResponseHeaders
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmResponseHeaders";
            this.Text = "frmResponseHeaders";
            this.Load += new System.EventHandler(this.frmResponseHeaders_Load);
            this.ResumeLayout(false);

        }

        private void frmResponseHeaders_Load(object sender, EventArgs e)
        {

        }
    }
}
