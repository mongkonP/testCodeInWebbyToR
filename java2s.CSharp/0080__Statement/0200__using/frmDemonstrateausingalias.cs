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
    //http://www.java2s.com/Tutorial/CSharp/0080__Statement/Demonstrateausingalias.htm
    public partial  class frmDemonstrateausingalias:Form
    {
        public frmDemonstrateausingalias()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstrateausingalias
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstrateausingalias";
            this.Text = "frmDemonstrateausingalias";
            this.Load += new System.EventHandler(this.frmDemonstrateausingalias_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstrateausingalias_Load(object sender, EventArgs e)
        {

        }
    }
}
