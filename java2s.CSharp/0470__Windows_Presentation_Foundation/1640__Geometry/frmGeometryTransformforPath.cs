using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1640__Geometry
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GeometryTransformforPath.htm
    public partial  class frmGeometryTransformforPath:Form
    {
        public frmGeometryTransformforPath()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGeometryTransformforPath
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGeometryTransformforPath";
            this.Text = "frmGeometryTransformforPath";
            this.Load += new System.EventHandler(this.frmGeometryTransformforPath_Load);
            this.ResumeLayout(false);

        }

        private void frmGeometryTransformforPath_Load(object sender, EventArgs e)
        {

        }
    }
}
