using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0600__Security.C0140__ProtectedData
{
    //http://www.java2s.com/Tutorial/CSharp/0600__Security/UsingProtectedMemorytoprotectastring.htm
    public partial  class frmUsingProtectedMemorytoprotectastring:Form
    {
        public frmUsingProtectedMemorytoprotectastring()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingProtectedMemorytoprotectastring
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingProtectedMemorytoprotectastring";
            this.Text = "frmUsingProtectedMemorytoprotectastring";
            this.Load += new System.EventHandler(this.frmUsingProtectedMemorytoprotectastring_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingProtectedMemorytoprotectastring_Load(object sender, EventArgs e)
        {

        }
    }
}
