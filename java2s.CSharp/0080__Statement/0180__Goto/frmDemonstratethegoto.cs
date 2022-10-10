using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0180__Goto
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Demonstratethegoto.htm
    public partial  class frmDemonstratethegoto:Form
    {
        public frmDemonstratethegoto()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstratethegoto
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstratethegoto";
            this.Text = "frmDemonstratethegoto";
            this.Load += new System.EventHandler(this.frmDemonstratethegoto_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstratethegoto_Load(object sender, EventArgs e)
        {

        }
    }
}
