using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0040__Role
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/Checkingforaccessinarole.htm
    public partial  class frmCheckingforaccessinarole:Form
    {
        public frmCheckingforaccessinarole()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCheckingforaccessinarole
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCheckingforaccessinarole";
            this.Text = "frmCheckingforaccessinarole";
            this.Load += new System.EventHandler(this.frmCheckingforaccessinarole_Load);
            this.ResumeLayout(false);

        }

        private void frmCheckingforaccessinarole_Load(object sender, EventArgs e)
        {

        }
    }
}
