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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PolygonAlongwithCanvas.htm
    public partial  class frmPolygonAlongwithCanvas:Form
    {
        public frmPolygonAlongwithCanvas()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPolygonAlongwithCanvas
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPolygonAlongwithCanvas";
            this.Text = "frmPolygonAlongwithCanvas";
            this.Load += new System.EventHandler(this.frmPolygonAlongwithCanvas_Load);
            this.ResumeLayout(false);

        }

        private void frmPolygonAlongwithCanvas_Load(object sender, EventArgs e)
        {

        }
    }
}
