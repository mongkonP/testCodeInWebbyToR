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
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Delegatescanrefertoinstancemethods.htm
    public partial  class frmDelegatescanrefertoinstancemethods:Form
    {
        public frmDelegatescanrefertoinstancemethods()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDelegatescanrefertoinstancemethods
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDelegatescanrefertoinstancemethods";
            this.Text = "frmDelegatescanrefertoinstancemethods";
            this.Load += new System.EventHandler(this.frmDelegatescanrefertoinstancemethods_Load);
            this.ResumeLayout(false);

        }

        private void frmDelegatescanrefertoinstancemethods_Load(object sender, EventArgs e)
        {

        }
    }
}
