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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnimateEndPoint.htm
    public partial  class frmAnimateEndPoint:Form
    {
        public frmAnimateEndPoint()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimateEndPoint
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimateEndPoint";
            this.Text = "frmAnimateEndPoint";
            this.Load += new System.EventHandler(this.frmAnimateEndPoint_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimateEndPoint_Load(object sender, EventArgs e)
        {

        }
    }
}
