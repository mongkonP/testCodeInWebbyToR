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
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/Assemblies.htm
    public partial  class frmAssemblies:Form
    {
        public frmAssemblies()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAssemblies
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAssemblies";
            this.Text = "frmAssemblies";
            this.Load += new System.EventHandler(this.frmAssemblies_Load);
            this.ResumeLayout(false);

        }

        private void frmAssemblies_Load(object sender, EventArgs e)
        {

        }
    }
}
