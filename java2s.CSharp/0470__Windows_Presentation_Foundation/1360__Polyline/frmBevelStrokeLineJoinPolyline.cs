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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/BevelStrokeLineJoinPolyline.htm
    public partial  class frmBevelStrokeLineJoinPolyline:Form
    {
        public frmBevelStrokeLineJoinPolyline()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBevelStrokeLineJoinPolyline
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBevelStrokeLineJoinPolyline";
            this.Text = "frmBevelStrokeLineJoinPolyline";
            this.Load += new System.EventHandler(this.frmBevelStrokeLineJoinPolyline_Load);
            this.ResumeLayout(false);

        }

        private void frmBevelStrokeLineJoinPolyline_Load(object sender, EventArgs e)
        {

        }
    }
}
