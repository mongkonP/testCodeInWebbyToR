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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/LoadXamlResource.htm
    public partial  class frmLoadXamlResource:Form
    {
        public frmLoadXamlResource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadXamlResource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadXamlResource";
            this.Text = "frmLoadXamlResource";
            this.Load += new System.EventHandler(this.frmLoadXamlResource_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadXamlResource_Load(object sender, EventArgs e)
        {

        }
    }
}
