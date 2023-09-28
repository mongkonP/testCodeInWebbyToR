using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2500__3D
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Paintinga3Dsurfacewithabitmap.htm
    public partial  class frmPaintinga3Dsurfacewithabitmap:Form
    {
        public frmPaintinga3Dsurfacewithabitmap()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPaintinga3Dsurfacewithabitmap
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPaintinga3Dsurfacewithabitmap";
            this.Text = "frmPaintinga3Dsurfacewithabitmap";
            this.Load += new System.EventHandler(this.frmPaintinga3Dsurfacewithabitmap_Load);
            this.ResumeLayout(false);

        }

        private void frmPaintinga3Dsurfacewithabitmap_Load(object sender, EventArgs e)
        {

        }
    }
}
