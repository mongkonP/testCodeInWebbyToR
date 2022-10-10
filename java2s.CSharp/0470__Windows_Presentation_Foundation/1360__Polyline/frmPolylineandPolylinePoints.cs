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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PolylineandPolylinePoints.htm
    public partial  class frmPolylineandPolylinePoints:Form
    {
        public frmPolylineandPolylinePoints()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPolylineandPolylinePoints
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPolylineandPolylinePoints";
            this.Text = "frmPolylineandPolylinePoints";
            this.Load += new System.EventHandler(this.frmPolylineandPolylinePoints_Load);
            this.ResumeLayout(false);

        }

        private void frmPolylineandPolylinePoints_Load(object sender, EventArgs e)
        {

        }
    }
}
