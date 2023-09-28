using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0480__Asynchronous
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Useasyncjobtocompute.htm
    public partial  class frmUseasyncjobtocompute:Form
    {
        public frmUseasyncjobtocompute()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseasyncjobtocompute
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseasyncjobtocompute";
            this.Text = "frmUseasyncjobtocompute";
            this.Load += new System.EventHandler(this.frmUseasyncjobtocompute_Load);
            this.ResumeLayout(false);

        }

        private void frmUseasyncjobtocompute_Load(object sender, EventArgs e)
        {

        }
    }
}
