using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0580__ThreadPool
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/UseThreadPooltoimplementahelloserver.htm
    public partial  class frmUseThreadPooltoimplementahelloserver:Form
    {
        public frmUseThreadPooltoimplementahelloserver()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseThreadPooltoimplementahelloserver
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseThreadPooltoimplementahelloserver";
            this.Text = "frmUseThreadPooltoimplementahelloserver";
            this.Load += new System.EventHandler(this.frmUseThreadPooltoimplementahelloserver_Load);
            this.ResumeLayout(false);

        }

        private void frmUseThreadPooltoimplementahelloserver_Load(object sender, EventArgs e)
        {

        }
    }
}
