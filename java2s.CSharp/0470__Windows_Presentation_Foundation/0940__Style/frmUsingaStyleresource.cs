using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0940__Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UsingaStyleresource.htm
    public partial  class frmUsingaStyleresource:Form
    {
        public frmUsingaStyleresource()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUsingaStyleresource
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUsingaStyleresource";
            this.Text = "frmUsingaStyleresource";
            this.Load += new System.EventHandler(this.frmUsingaStyleresource_Load);
            this.ResumeLayout(false);

        }

        private void frmUsingaStyleresource_Load(object sender, EventArgs e)
        {

        }
    }
}
