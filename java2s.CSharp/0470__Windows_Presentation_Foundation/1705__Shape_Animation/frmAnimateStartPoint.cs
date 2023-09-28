using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1705__Shape_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnimateStartPoint.htm
    public partial  class frmAnimateStartPoint:Form
    {
        public frmAnimateStartPoint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimateStartPoint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimateStartPoint";
            this.Text = "frmAnimateStartPoint";
            this.Load += new System.EventHandler(this.frmAnimateStartPoint_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimateStartPoint_Load(object sender, EventArgs e)
        {

        }
    }
}
