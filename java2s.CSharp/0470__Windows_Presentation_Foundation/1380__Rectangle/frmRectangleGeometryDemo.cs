using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1380__Rectangle
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RectangleGeometryDemo.htm
    public partial  class frmRectangleGeometryDemo:Form
    {
        public frmRectangleGeometryDemo()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRectangleGeometryDemo
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRectangleGeometryDemo";
            this.Text = "frmRectangleGeometryDemo";
            this.Load += new System.EventHandler(this.frmRectangleGeometryDemo_Load);
            this.ResumeLayout(false);

        }

        private void frmRectangleGeometryDemo_Load(object sender, EventArgs e)
        {

        }
    }
}
