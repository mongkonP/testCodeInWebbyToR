using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0080__Anonymous_delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Demonstrateacapturedvariable.htm
    public partial  class frmDemonstrateacapturedvariable:Form
    {
        public frmDemonstrateacapturedvariable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDemonstrateacapturedvariable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDemonstrateacapturedvariable";
            this.Text = "frmDemonstrateacapturedvariable";
            this.Load += new System.EventHandler(this.frmDemonstrateacapturedvariable_Load);
            this.ResumeLayout(false);

        }

        private void frmDemonstrateacapturedvariable_Load(object sender, EventArgs e)
        {

        }
    }
}
