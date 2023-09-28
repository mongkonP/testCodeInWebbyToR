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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Drawa3DModel.htm
    public partial  class frmDrawa3DModel:Form
    {
        public frmDrawa3DModel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawa3DModel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawa3DModel";
            this.Text = "frmDrawa3DModel";
            this.Load += new System.EventHandler(this.frmDrawa3DModel_Load);
            this.ResumeLayout(false);

        }

        private void frmDrawa3DModel_Load(object sender, EventArgs e)
        {

        }
    }
}
