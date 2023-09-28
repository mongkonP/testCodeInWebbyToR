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
    //http://www.java2s.com/Tutorial/CSharp/0400__Reflection/ExecuteAssembly.htm
    public partial  class frmExecuteAssembly:Form
    {
        public frmExecuteAssembly()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmExecuteAssembly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmExecuteAssembly";
            this.Text = "frmExecuteAssembly";
            this.Load += new System.EventHandler(this.frmExecuteAssembly_Load);
            this.ResumeLayout(false);

        }

        private void frmExecuteAssembly_Load(object sender, EventArgs e)
        {

        }
    }
}
