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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/LogicalResources.htm
    public partial  class frmLogicalResources:Form
    {
        public frmLogicalResources()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLogicalResources
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLogicalResources";
            this.Text = "frmLogicalResources";
            this.Load += new System.EventHandler(this.frmLogicalResources_Load);
            this.ResumeLayout(false);

        }

        private void frmLogicalResources_Load(object sender, EventArgs e)
        {

        }
    }
}
