using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0400__Reflection.C0220__Assembly
{
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/LoadAssemblyfromDll.htm
    public partial  class frmLoadAssemblyfromDll:Form
    {
        public frmLoadAssemblyfromDll()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadAssemblyfromDll
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadAssemblyfromDll";
            this.Text = "frmLoadAssemblyfromDll";
            this.Load += new System.EventHandler(this.frmLoadAssemblyfromDll_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadAssemblyfromDll_Load(object sender, EventArgs e)
        {

        }
    }
}
