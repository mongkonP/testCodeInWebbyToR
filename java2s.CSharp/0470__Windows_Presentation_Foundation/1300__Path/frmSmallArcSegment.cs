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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/SmallArcSegment.htm
    public partial  class frmSmallArcSegment:Form
    {
        public frmSmallArcSegment()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSmallArcSegment
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSmallArcSegment";
            this.Text = "frmSmallArcSegment";
            this.Load += new System.EventHandler(this.frmSmallArcSegment_Load);
            this.ResumeLayout(false);

        }

        private void frmSmallArcSegment_Load(object sender, EventArgs e)
        {

        }
    }
}
