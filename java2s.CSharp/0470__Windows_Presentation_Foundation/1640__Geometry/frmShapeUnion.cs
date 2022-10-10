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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ShapeUnion.htm
    public partial  class frmShapeUnion:Form
    {
        public frmShapeUnion()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmShapeUnion
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmShapeUnion";
            this.Text = "frmShapeUnion";
            this.Load += new System.EventHandler(this.frmShapeUnion_Load);
            this.ResumeLayout(false);

        }

        private void frmShapeUnion_Load(object sender, EventArgs e)
        {

        }
    }
}
