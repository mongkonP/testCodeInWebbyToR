using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1880__Mouse
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/HandlestheMouseDowneventontheUniformGrid.htm
    public partial  class frmHandlestheMouseDowneventontheUniformGrid:Form
    {
        public frmHandlestheMouseDowneventontheUniformGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHandlestheMouseDowneventontheUniformGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHandlestheMouseDowneventontheUniformGrid";
            this.Text = "frmHandlestheMouseDowneventontheUniformGrid";
            this.Load += new System.EventHandler(this.frmHandlestheMouseDowneventontheUniformGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmHandlestheMouseDowneventontheUniformGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
