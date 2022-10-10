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
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/AnonymousMethods.htm
    public partial  class frmAnonymousMethods:Form
    {
        public frmAnonymousMethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnonymousMethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnonymousMethods";
            this.Text = "frmAnonymousMethods";
            this.Load += new System.EventHandler(this.frmAnonymousMethods_Load);
            this.ResumeLayout(false);

        }

        private void frmAnonymousMethods_Load(object sender, EventArgs e)
        {

        }
    }
}
