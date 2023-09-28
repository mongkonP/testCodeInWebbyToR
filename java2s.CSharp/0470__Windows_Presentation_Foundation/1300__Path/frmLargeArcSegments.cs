using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1300__Path
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/LargeArcSegments.htm
    public partial  class frmLargeArcSegments:Form
    {
        public frmLargeArcSegments()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmLargeArcSegments
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmLargeArcSegments";
            this.Text = "frmLargeArcSegments";
            this.Load += new System.EventHandler(this.frmLargeArcSegments_Load);
            this.ResumeLayout(false);

        }

        private void frmLargeArcSegments_Load(object sender, EventArgs e)
        {

        }
    }
}
