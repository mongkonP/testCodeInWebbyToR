using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0580__Network.C0500__EMail
{
    //http://www.java2s.com/Tutorial/CSharp/0580__Network/Sendanemailout.htm
    public partial  class frmSendanemailout:Form
    {
        public frmSendanemailout()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSendanemailout
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSendanemailout";
            this.Text = "frmSendanemailout";
            this.Load += new System.EventHandler(this.frmSendanemailout_Load);
            this.ResumeLayout(false);

        }

        private void frmSendanemailout_Load(object sender, EventArgs e)
        {

        }
    }
}
