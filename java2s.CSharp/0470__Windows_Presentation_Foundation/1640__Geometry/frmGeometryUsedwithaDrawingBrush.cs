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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GeometryUsedwithaDrawingBrush.htm
    public partial  class frmGeometryUsedwithaDrawingBrush:Form
    {
        public frmGeometryUsedwithaDrawingBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGeometryUsedwithaDrawingBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGeometryUsedwithaDrawingBrush";
            this.Text = "frmGeometryUsedwithaDrawingBrush";
            this.Load += new System.EventHandler(this.frmGeometryUsedwithaDrawingBrush_Load);
            this.ResumeLayout(false);

        }

        private void frmGeometryUsedwithaDrawingBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
