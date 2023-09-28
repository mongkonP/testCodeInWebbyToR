using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0420__Thread.C0020__Thread_Creation
{
    //http://www.java2s.com/Tutorial/CSharp/0420__Thread/Threadmethodwithnoparameter.htm
    public partial  class frmThreadmethodwithnoparameter:Form
    {
        public frmThreadmethodwithnoparameter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmThreadmethodwithnoparameter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmThreadmethodwithnoparameter";
            this.Text = "frmThreadmethodwithnoparameter";
            this.Load += new System.EventHandler(this.frmThreadmethodwithnoparameter_Load);
            this.ResumeLayout(false);

        }

        private void frmThreadmethodwithnoparameter_Load(object sender, EventArgs e)
        {

        }
    }
}
