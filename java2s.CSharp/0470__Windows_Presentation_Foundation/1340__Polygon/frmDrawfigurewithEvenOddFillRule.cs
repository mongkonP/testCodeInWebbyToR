using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1340__Polygon
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DrawfigurewithEvenOddFillRule.htm
    public partial  class frmDrawfigurewithEvenOddFillRule:Form
    {
        public frmDrawfigurewithEvenOddFillRule()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDrawfigurewithEvenOddFillRule
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDrawfigurewithEvenOddFillRule";
            this.Text = "frmDrawfigurewithEvenOddFillRule";
            this.Load += new System.EventHandler(this.frmDrawfigurewithEvenOddFillRule_Load);
            this.ResumeLayout(false);

        }

        private void frmDrawfigurewithEvenOddFillRule_Load(object sender, EventArgs e)
        {

        }
    }
}
