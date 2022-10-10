using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0100__Socket_Client
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/Socketconnection.htm
    public partial  class frmSocketconnection:Form
    {
        public frmSocketconnection()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSocketconnection
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSocketconnection";
            this.Text = "frmSocketconnection";
            this.Load += new System.EventHandler(this.frmSocketconnection_Load);
            this.ResumeLayout(false);

        }

        private void frmSocketconnection_Load(object sender, EventArgs e)
        {

        }
    }
}
