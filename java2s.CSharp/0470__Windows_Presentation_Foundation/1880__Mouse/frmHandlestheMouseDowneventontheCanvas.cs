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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/HandlestheMouseDowneventontheCanvas.htm
    public partial  class frmHandlestheMouseDowneventontheCanvas:Form
    {
        public frmHandlestheMouseDowneventontheCanvas()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHandlestheMouseDowneventontheCanvas
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHandlestheMouseDowneventontheCanvas";
            this.Text = "frmHandlestheMouseDowneventontheCanvas";
            this.Load += new System.EventHandler(this.frmHandlestheMouseDowneventontheCanvas_Load);
            this.ResumeLayout(false);

        }

        private void frmHandlestheMouseDowneventontheCanvas_Load(object sender, EventArgs e)
        {

        }
    }
}
