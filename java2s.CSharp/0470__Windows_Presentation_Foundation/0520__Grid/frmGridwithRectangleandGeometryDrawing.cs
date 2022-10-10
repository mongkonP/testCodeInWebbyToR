using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0520__Grid
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GridwithRectangleandGeometryDrawing.htm
    public partial  class frmGridwithRectangleandGeometryDrawing:Form
    {
        public frmGridwithRectangleandGeometryDrawing()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGridwithRectangleandGeometryDrawing
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGridwithRectangleandGeometryDrawing";
            this.Text = "frmGridwithRectangleandGeometryDrawing";
            this.Load += new System.EventHandler(this.frmGridwithRectangleandGeometryDrawing_Load);
            this.ResumeLayout(false);

        }

        private void frmGridwithRectangleandGeometryDrawing_Load(object sender, EventArgs e)
        {

        }
    }
}
