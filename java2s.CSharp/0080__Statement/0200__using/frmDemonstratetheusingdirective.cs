using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0200__using
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Demonstratetheusingdirective.htm
    public partial  class frmDemonstratetheusingdirective:Form
    {
        public frmDemonstratetheusingdirective()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstratetheusingdirective
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstratetheusingdirective";
            this.Text = "frmDemonstratetheusingdirective";
            this.Load += new System.EventHandler(this.frmDemonstratetheusingdirective_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstratetheusingdirective_Load(object sender, EventArgs e)
        {

        }
    }
}
