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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/MeshGeometry3DwithTextureCoordinates.htm
    public partial  class frmMeshGeometry3DwithTextureCoordinates:Form
    {
        public frmMeshGeometry3DwithTextureCoordinates()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMeshGeometry3DwithTextureCoordinates
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMeshGeometry3DwithTextureCoordinates";
            this.Text = "frmMeshGeometry3DwithTextureCoordinates";
            this.Load += new System.EventHandler(this.frmMeshGeometry3DwithTextureCoordinates_Load);
            this.ResumeLayout(false);

        }

        private void frmMeshGeometry3DwithTextureCoordinates_Load(object sender, EventArgs e)
        {

        }
    }
}
