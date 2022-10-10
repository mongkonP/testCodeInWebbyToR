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
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Ananonymousmethodthatreturnsavalue.htm
    public partial  class frmAnanonymousmethodthatreturnsavalue:Form
    {
        public frmAnanonymousmethodthatreturnsavalue()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnanonymousmethodthatreturnsavalue
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnanonymousmethodthatreturnsavalue";
            this.Text = "frmAnanonymousmethodthatreturnsavalue";
            this.Load += new System.EventHandler(this.frmAnanonymousmethodthatreturnsavalue_Load);
            this.ResumeLayout(false);

        }

        private void frmAnanonymousmethodthatreturnsavalue_Load(object sender, EventArgs e)
        {

        }
    }
}
