using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0100__String.C0020__String
{
    //http://www.java2s.com/Tutorial/CSharp/0100__String/ErrorstringIsImmutable.htm
    public partial  class frmErrorstringIsImmutable:Form
    {
        public frmErrorstringIsImmutable()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmErrorstringIsImmutable
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmErrorstringIsImmutable";
            this.Text = "frmErrorstringIsImmutable";
            this.Load += new System.EventHandler(this.frmErrorstringIsImmutable_Load);
            this.ResumeLayout(false);

        }

        private void frmErrorstringIsImmutable_Load(object sender, EventArgs e)
        {

        }
    }
}
