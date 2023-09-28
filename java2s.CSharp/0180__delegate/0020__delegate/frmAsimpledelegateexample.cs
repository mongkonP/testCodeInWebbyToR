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
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/Asimpledelegateexample.htm
    public partial  class frmAsimpledelegateexample:Form
    {
        public frmAsimpledelegateexample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAsimpledelegateexample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAsimpledelegateexample";
            this.Text = "frmAsimpledelegateexample";
            this.Load += new System.EventHandler(this.frmAsimpledelegateexample_Load);
            this.ResumeLayout(false);

        }

        private void frmAsimpledelegateexample_Load(object sender, EventArgs e)
        {

        }
    }
}
