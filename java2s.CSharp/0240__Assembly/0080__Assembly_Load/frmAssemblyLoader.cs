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
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/AssemblyLoader.htm
    public partial  class frmAssemblyLoader:Form
    {
        public frmAssemblyLoader()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAssemblyLoader
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAssemblyLoader";
            this.Text = "frmAssemblyLoader";
            this.Load += new System.EventHandler(this.frmAssemblyLoader_Load);
            this.ResumeLayout(false);

        }

        private void frmAssemblyLoader_Load(object sender, EventArgs e)
        {

        }
    }
}
