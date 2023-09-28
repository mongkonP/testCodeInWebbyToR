using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0140__Class.C0360__protected
{
    //http://www.java2s.com/Tutorial/CSharp/0140__Class/Demonstrateprotected.htm
    public partial  class frmDemonstrateprotected:Form
    {
        public frmDemonstrateprotected()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstrateprotected
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstrateprotected";
            this.Text = "frmDemonstrateprotected";
            this.Load += new System.EventHandler(this.frmDemonstrateprotected_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstrateprotected_Load(object sender, EventArgs e)
        {

        }
    }
}
