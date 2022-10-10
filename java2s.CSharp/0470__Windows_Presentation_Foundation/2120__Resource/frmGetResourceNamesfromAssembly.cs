using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2120__Resource
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GetResourceNamesfromAssembly.htm
    public partial  class frmGetResourceNamesfromAssembly:Form
    {
        public frmGetResourceNamesfromAssembly()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGetResourceNamesfromAssembly
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGetResourceNamesfromAssembly";
            this.Text = "frmGetResourceNamesfromAssembly";
            this.Load += new System.EventHandler(this.frmGetResourceNamesfromAssembly_Load);
            this.ResumeLayout(false);

        }

        private void frmGetResourceNamesfromAssembly_Load(object sender, EventArgs e)
        {

        }
    }
}
