using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0020__delegate
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/DelegatestoInstanceMembers.htm
    public partial  class frmDelegatestoInstanceMembers:Form
    {
        public frmDelegatestoInstanceMembers()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDelegatestoInstanceMembers
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDelegatestoInstanceMembers";
            this.Text = "frmDelegatestoInstanceMembers";
            this.Load += new System.EventHandler(this.frmDelegatestoInstanceMembers_Load);
            this.ResumeLayout(false);

        }

        private void frmDelegatestoInstanceMembers_Load(object sender, EventArgs e)
        {

        }
    }
}
