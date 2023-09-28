using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0520__Windows.C0220__DLL
{
    //http://www.java2s.com/Tutorial/CSharp/0520__Windows/InvokeMessageBoxinDll.htm
    public partial  class frmInvokeMessageBoxinDll:Form
    {
        public frmInvokeMessageBoxinDll()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmInvokeMessageBoxinDll
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmInvokeMessageBoxinDll";
            this.Text = "frmInvokeMessageBoxinDll";
            this.Load += new System.EventHandler(this.frmInvokeMessageBoxinDll_Load);
            this.ResumeLayout(false);

        }

        private void frmInvokeMessageBoxinDll_Load(object sender, EventArgs e)
        {

        }
    }
}
