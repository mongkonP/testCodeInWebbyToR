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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PolygonStretchUniformToFill.htm
    public partial  class frmPolygonStretchUniformToFill:Form
    {
        public frmPolygonStretchUniformToFill()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPolygonStretchUniformToFill
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPolygonStretchUniformToFill";
            this.Text = "frmPolygonStretchUniformToFill";
            this.Load += new System.EventHandler(this.frmPolygonStretchUniformToFill_Load);
            this.ResumeLayout(false);

        }

        private void frmPolygonStretchUniformToFill_Load(object sender, EventArgs e)
        {

        }
    }
}
