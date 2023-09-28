using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1360__Polyline
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PolyLineSegmentDemo.htm
    public partial  class frmPolyLineSegmentDemo:Form
    {
        public frmPolyLineSegmentDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPolyLineSegmentDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPolyLineSegmentDemo";
            this.Text = "frmPolyLineSegmentDemo";
            this.Load += new System.EventHandler(this.frmPolyLineSegmentDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmPolyLineSegmentDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
