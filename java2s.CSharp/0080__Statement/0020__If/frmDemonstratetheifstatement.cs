using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0080__Statement.C0020__If
{
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Demonstratetheifstatement.htm
    public partial  class frmDemonstratetheifstatement:Form
    {
        public frmDemonstratetheifstatement()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstratetheifstatement
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstratetheifstatement";
            this.Text = "frmDemonstratetheifstatement";
            this.Load += new System.EventHandler(this.frmDemonstratetheifstatement_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstratetheifstatement_Load(object sender, EventArgs e)
        {

        }
    }
}
