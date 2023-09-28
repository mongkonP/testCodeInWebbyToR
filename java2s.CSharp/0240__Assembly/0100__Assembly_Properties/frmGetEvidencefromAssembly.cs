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
    //http://www.java2s.com/Tutorial/CSharp/0240__Assembly/GetEvidencefromAssembly.htm
    public partial  class frmGetEvidencefromAssembly:Form
    {
        public frmGetEvidencefromAssembly()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetEvidencefromAssembly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetEvidencefromAssembly";
            this.Text = "frmGetEvidencefromAssembly";
            this.Load += new System.EventHandler(this.frmGetEvidencefromAssembly_Load);
            this.ResumeLayout(false);

        }

        private void frmGetEvidencefromAssembly_Load(object sender, EventArgs e)
        {

        }
    }
}
