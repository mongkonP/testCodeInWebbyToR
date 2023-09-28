using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0240__DllImport
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/GetaddressofamethodfromDll.htm
    public partial  class frmGetaddressofamethodfromDll:Form
    {
        public frmGetaddressofamethodfromDll()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetaddressofamethodfromDll
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetaddressofamethodfromDll";
            this.Text = "frmGetaddressofamethodfromDll";
            this.Load += new System.EventHandler(this.frmGetaddressofamethodfromDll_Load);
            this.ResumeLayout(false);

        }

        private void frmGetaddressofamethodfromDll_Load(object sender, EventArgs e)
        {

        }
    }
}
