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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TiledGeometry.htm
    public partial  class frmTiledGeometry:Form
    {
        public frmTiledGeometry()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTiledGeometry
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTiledGeometry";
            this.Text = "frmTiledGeometry";
            this.Load += new System.EventHandler(this.frmTiledGeometry_Load);
            this.ResumeLayout(false);

        }

        private void frmTiledGeometry_Load(object sender, EventArgs e)
        {

        }
    }
}
