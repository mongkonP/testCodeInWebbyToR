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
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/AssemblyGetCallingAssemblyinaThread.htm
    public partial  class frmAssemblyGetCallingAssemblyinaThread:Form
    {
        public frmAssemblyGetCallingAssemblyinaThread()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAssemblyGetCallingAssemblyinaThread
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAssemblyGetCallingAssemblyinaThread";
            this.Text = "frmAssemblyGetCallingAssemblyinaThread";
            this.Load += new System.EventHandler(this.frmAssemblyGetCallingAssemblyinaThread_Load);
            this.ResumeLayout(false);

        }

        private void frmAssemblyGetCallingAssemblyinaThread_Load(object sender, EventArgs e)
        {

        }
    }
}
