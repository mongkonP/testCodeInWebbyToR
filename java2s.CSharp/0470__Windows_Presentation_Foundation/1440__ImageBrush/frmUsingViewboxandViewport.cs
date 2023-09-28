using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1440__ImageBrush
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UsingViewboxandViewport.htm
    public partial  class frmUsingViewboxandViewport:Form
    {
        public frmUsingViewboxandViewport()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingViewboxandViewport
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingViewboxandViewport";
            this.Text = "frmUsingViewboxandViewport";
            this.Load += new System.EventHandler(this.frmUsingViewboxandViewport_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingViewboxandViewport_Load(object sender, EventArgs e)
        {

        }
    }
}
