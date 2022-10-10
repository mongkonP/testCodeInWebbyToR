using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2520__Matrix3D
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Matrix3DRotateAt.htm
    public partial  class frmMatrix3DRotateAt:Form
    {
        public frmMatrix3DRotateAt()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMatrix3DRotateAt
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMatrix3DRotateAt";
            this.Text = "frmMatrix3DRotateAt";
            this.Load += new System.EventHandler(this.frmMatrix3DRotateAt_Load);
            this.ResumeLayout(false);

        }

        private void frmMatrix3DRotateAt_Load(object sender, EventArgs e)
        {

        }
    }
}
