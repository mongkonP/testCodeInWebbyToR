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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PolygonwithFill.htm
    public partial  class frmPolygonwithFill:Form
    {
        public frmPolygonwithFill()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPolygonwithFill
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPolygonwithFill";
            this.Text = "frmPolygonwithFill";
            this.Load += new System.EventHandler(this.frmPolygonwithFill_Load);
            this.ResumeLayout(false);

        }

        private void frmPolygonwithFill_Load(object sender, EventArgs e)
        {

        }
    }
}
