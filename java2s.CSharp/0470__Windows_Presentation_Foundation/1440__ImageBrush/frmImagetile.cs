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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Imagetile.htm
    public partial  class frmImagetile:Form
    {
        public frmImagetile()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmImagetile
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmImagetile";
            this.Text = "frmImagetile";
            this.Load += new System.EventHandler(this.frmImagetile_Load);
            this.ResumeLayout(false);

        }

        private void frmImagetile_Load(object sender, EventArgs e)
        {

        }
    }
}
