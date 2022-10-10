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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PolygonStretchUniform.htm
    public partial  class frmPolygonStretchUniform:Form
    {
        public frmPolygonStretchUniform()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPolygonStretchUniform
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPolygonStretchUniform";
            this.Text = "frmPolygonStretchUniform";
            this.Load += new System.EventHandler(this.frmPolygonStretchUniform_Load);
            this.ResumeLayout(false);

        }

        private void frmPolygonStretchUniform_Load(object sender, EventArgs e)
        {

        }
    }
}
