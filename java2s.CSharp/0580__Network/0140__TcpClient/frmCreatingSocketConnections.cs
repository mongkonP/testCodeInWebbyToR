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
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/CreatingSocketConnections.htm
    public partial  class frmCreatingSocketConnections:Form
    {
        public frmCreatingSocketConnections()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCreatingSocketConnections
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCreatingSocketConnections";
            this.Text = "frmCreatingSocketConnections";
            this.Load += new System.EventHandler(this.frmCreatingSocketConnections_Load);
            this.ResumeLayout(false);

        }

        private void frmCreatingSocketConnections_Load(object sender, EventArgs e)
        {

        }
    }
}
