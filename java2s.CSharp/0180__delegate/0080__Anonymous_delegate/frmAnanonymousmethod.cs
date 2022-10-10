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
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Ananonymousmethod.htm
    public partial  class frmAnanonymousmethod:Form
    {
        public frmAnanonymousmethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnanonymousmethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnanonymousmethod";
            this.Text = "frmAnanonymousmethod";
            this.Load += new System.EventHandler(this.frmAnanonymousmethod_Load);
            this.ResumeLayout(false);

        }

        private void frmAnanonymousmethod_Load(object sender, EventArgs e)
        {

        }
    }
}
