using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1260__Ellipse
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EllipseFillwithDrawingBrush.htm
    public partial  class frmEllipseFillwithDrawingBrush:Form
    {
        public frmEllipseFillwithDrawingBrush()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEllipseFillwithDrawingBrush
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEllipseFillwithDrawingBrush";
            this.Text = "frmEllipseFillwithDrawingBrush";
            this.Load += new System.EventHandler(this.frmEllipseFillwithDrawingBrush_Load);
            this.ResumeLayout(false);

        }

        private void frmEllipseFillwithDrawingBrush_Load(object sender, EventArgs e)
        {

        }
    }
}
