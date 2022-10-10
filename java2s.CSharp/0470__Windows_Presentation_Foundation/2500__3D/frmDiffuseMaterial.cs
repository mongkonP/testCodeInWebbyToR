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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DiffuseMaterial.htm
    public partial  class frmDiffuseMaterial:Form
    {
        public frmDiffuseMaterial()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDiffuseMaterial
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDiffuseMaterial";
            this.Text = "frmDiffuseMaterial";
            this.Load += new System.EventHandler(this.frmDiffuseMaterial_Load);
            this.ResumeLayout(false);

        }

        private void frmDiffuseMaterial_Load(object sender, EventArgs e)
        {

        }
    }
}
