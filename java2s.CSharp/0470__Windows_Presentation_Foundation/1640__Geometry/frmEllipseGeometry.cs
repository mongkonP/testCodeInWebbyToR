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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EllipseGeometry.htm
    public partial  class frmEllipseGeometry:Form
    {
        public frmEllipseGeometry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEllipseGeometry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEllipseGeometry";
            this.Text = "frmEllipseGeometry";
            this.Load += new System.EventHandler(this.frmEllipseGeometry_Load);
            this.ResumeLayout(false);

        }

        private void frmEllipseGeometry_Load(object sender, EventArgs e)
        {

        }
    }
}
