using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0540__Chat
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/TcpChar2.htm
    public partial  class frmTcpChar2:Form
    {
        public frmTcpChar2()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTcpChar2
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTcpChar2";
            this.Text = "frmTcpChar2";
            this.Load += new System.EventHandler(this.frmTcpChar2_Load);
            this.ResumeLayout(false);

        }

        private void frmTcpChar2_Load(object sender, EventArgs e)
        {

        }
    }
}
