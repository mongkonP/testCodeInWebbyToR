using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1360__Polyline
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AddPolylinetoUniformGrid.htm
    public partial  class frmAddPolylinetoUniformGrid:Form
    {
        public frmAddPolylinetoUniformGrid()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAddPolylinetoUniformGrid
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAddPolylinetoUniformGrid";
            this.Text = "frmAddPolylinetoUniformGrid";
            this.Load += new System.EventHandler(this.frmAddPolylinetoUniformGrid_Load);
            this.ResumeLayout(false);

        }

        private void frmAddPolylinetoUniformGrid_Load(object sender, EventArgs e)
        {

        }
    }
}
