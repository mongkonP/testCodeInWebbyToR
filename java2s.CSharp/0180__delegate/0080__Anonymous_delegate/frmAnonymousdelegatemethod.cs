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
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Anonymousdelegatemethod.htm
    public partial  class frmAnonymousdelegatemethod:Form
    {
        public frmAnonymousdelegatemethod()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnonymousdelegatemethod
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnonymousdelegatemethod";
            this.Text = "frmAnonymousdelegatemethod";
            this.Load += new System.EventHandler(this.frmAnonymousdelegatemethod_Load);
            this.ResumeLayout(false);

        }

        private void frmAnonymousdelegatemethod_Load(object sender, EventArgs e)
        {

        }
    }
}
