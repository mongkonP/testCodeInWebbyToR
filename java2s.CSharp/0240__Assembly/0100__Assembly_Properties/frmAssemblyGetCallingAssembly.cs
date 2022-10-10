using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0240__Assembly.C0100__Assembly_Properties
{
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/AssemblyGetCallingAssembly.htm
    public partial  class frmAssemblyGetCallingAssembly:Form
    {
        public frmAssemblyGetCallingAssembly()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAssemblyGetCallingAssembly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAssemblyGetCallingAssembly";
            this.Text = "frmAssemblyGetCallingAssembly";
            this.Load += new System.EventHandler(this.frmAssemblyGetCallingAssembly_Load);
            this.ResumeLayout(false);

        }

        private void frmAssemblyGetCallingAssembly_Load(object sender, EventArgs e)
        {

        }
    }
}
