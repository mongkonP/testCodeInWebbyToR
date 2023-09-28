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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PolygonStretchFill.htm
    public partial  class frmPolygonStretchFill:Form
    {
        public frmPolygonStretchFill()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPolygonStretchFill
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPolygonStretchFill";
            this.Text = "frmPolygonStretchFill";
            this.Load += new System.EventHandler(this.frmPolygonStretchFill_Load);
            this.ResumeLayout(false);

        }

        private void frmPolygonStretchFill_Load(object sender, EventArgs e)
        {

        }
    }
}
