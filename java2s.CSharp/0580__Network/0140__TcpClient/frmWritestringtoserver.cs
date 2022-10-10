using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0140__TcpClient
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/Writestringtoserver.htm
    public partial  class frmWritestringtoserver:Form
    {
        public frmWritestringtoserver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWritestringtoserver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWritestringtoserver";
            this.Text = "frmWritestringtoserver";
            this.Load += new System.EventHandler(this.frmWritestringtoserver_Load);
            this.ResumeLayout(false);

        }

        private void frmWritestringtoserver_Load(object sender, EventArgs e)
        {

        }
    }
}
