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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EllipseWithStyledLines.htm
    public partial  class frmEllipseWithStyledLines:Form
    {
        public frmEllipseWithStyledLines()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEllipseWithStyledLines
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEllipseWithStyledLines";
            this.Text = "frmEllipseWithStyledLines";
            this.Load += new System.EventHandler(this.frmEllipseWithStyledLines_Load);
            this.ResumeLayout(false);

        }

        private void frmEllipseWithStyledLines_Load(object sender, EventArgs e)
        {

        }
    }
}
