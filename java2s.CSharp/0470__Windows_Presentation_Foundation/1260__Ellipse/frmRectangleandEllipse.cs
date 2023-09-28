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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RectangleandEllipse.htm
    public partial  class frmRectangleandEllipse:Form
    {
        public frmRectangleandEllipse()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRectangleandEllipse
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRectangleandEllipse";
            this.Text = "frmRectangleandEllipse";
            this.Load += new System.EventHandler(this.frmRectangleandEllipse_Load);
            this.ResumeLayout(false);

        }

        private void frmRectangleandEllipse_Load(object sender, EventArgs e)
        {

        }
    }
}
