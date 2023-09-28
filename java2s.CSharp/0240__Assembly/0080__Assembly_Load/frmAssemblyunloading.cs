using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0080__Assembly_Load
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/Assemblyunloading.htm
    public partial  class frmAssemblyunloading:Form
    {
        public frmAssemblyunloading()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAssemblyunloading
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAssemblyunloading";
            this.Text = "frmAssemblyunloading";
            this.Load += new System.EventHandler(this.frmAssemblyunloading_Load);
            this.ResumeLayout(false);

        }

        private void frmAssemblyunloading_Load(object sender, EventArgs e)
        {

        }
    }
}
