using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0060__Chained_delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/DelegateCombine.htm
    public partial  class frmDelegateCombine:Form
    {
        public frmDelegateCombine()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDelegateCombine
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDelegateCombine";
            this.Text = "frmDelegateCombine";
            this.Load += new System.EventHandler(this.frmDelegateCombine_Load);
            this.ResumeLayout(false);

        }

        private void frmDelegateCombine_Load(object sender, EventArgs e)
        {

        }
    }
}
