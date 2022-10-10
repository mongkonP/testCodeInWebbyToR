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
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/GetEntryAssembly.htm
    public partial  class frmGetEntryAssembly:Form
    {
        public frmGetEntryAssembly()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetEntryAssembly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetEntryAssembly";
            this.Text = "frmGetEntryAssembly";
            this.Load += new System.EventHandler(this.frmGetEntryAssembly_Load);
            this.ResumeLayout(false);

        }

        private void frmGetEntryAssembly_Load(object sender, EventArgs e)
        {

        }
    }
}
