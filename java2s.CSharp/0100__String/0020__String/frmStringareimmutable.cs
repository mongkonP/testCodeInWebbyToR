using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0020__String
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/Stringareimmutable.htm
    public partial  class frmStringareimmutable:Form
    {
        public frmStringareimmutable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStringareimmutable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStringareimmutable";
            this.Text = "frmStringareimmutable";
            this.Load += new System.EventHandler(this.frmStringareimmutable_Load);
            this.ResumeLayout(false);

        }

        private void frmStringareimmutable_Load(object sender, EventArgs e)
        {

        }
    }
}
