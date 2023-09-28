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
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Ananonymousmethodthattakesanargument.htm
    public partial  class frmAnanonymousmethodthattakesanargument:Form
    {
        public frmAnanonymousmethodthattakesanargument()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnanonymousmethodthattakesanargument
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnanonymousmethodthattakesanargument";
            this.Text = "frmAnanonymousmethodthattakesanargument";
            this.Load += new System.EventHandler(this.frmAnanonymousmethodthattakesanargument_Load);
            this.ResumeLayout(false);

        }

        private void frmAnanonymousmethodthattakesanargument_Load(object sender, EventArgs e)
        {

        }
    }
}
