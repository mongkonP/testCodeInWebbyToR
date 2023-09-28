using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1340__Polygon
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PolylinebyPoints.htm
    public partial  class frmPolylinebyPoints:Form
    {
        public frmPolylinebyPoints()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPolylinebyPoints
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPolylinebyPoints";
            this.Text = "frmPolylinebyPoints";
            this.Load += new System.EventHandler(this.frmPolylinebyPoints_Load);
            this.ResumeLayout(false);

        }

        private void frmPolylinebyPoints_Load(object sender, EventArgs e)
        {

        }
    }
}
