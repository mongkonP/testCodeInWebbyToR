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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/LoadAssemblyResources.htm
    public partial  class frmLoadAssemblyResources:Form
    {
        public frmLoadAssemblyResources()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLoadAssemblyResources
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLoadAssemblyResources";
            this.Text = "frmLoadAssemblyResources";
            this.Load += new System.EventHandler(this.frmLoadAssemblyResources_Load);
            this.ResumeLayout(false);

        }

        private void frmLoadAssemblyResources_Load(object sender, EventArgs e)
        {

        }
    }
}
