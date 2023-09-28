using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0420__Canvas
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/CanvasPositioningPropertiesSample.htm
    public partial  class frmCanvasPositioningPropertiesSample:Form
    {
        public frmCanvasPositioningPropertiesSample()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCanvasPositioningPropertiesSample
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCanvasPositioningPropertiesSample";
            this.Text = "frmCanvasPositioningPropertiesSample";
            this.Load += new System.EventHandler(this.frmCanvasPositioningPropertiesSample_Load);
            this.ResumeLayout(false);

        }

        private void frmCanvasPositioningPropertiesSample_Load(object sender, EventArgs e)
        {

        }
    }
}
