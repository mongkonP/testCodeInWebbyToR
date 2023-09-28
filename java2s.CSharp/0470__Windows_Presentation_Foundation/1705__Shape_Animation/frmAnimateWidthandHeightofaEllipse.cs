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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/AnimateWidthandHeightofaEllipse.htm
    public partial  class frmAnimateWidthandHeightofaEllipse:Form
    {
        public frmAnimateWidthandHeightofaEllipse()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAnimateWidthandHeightofaEllipse
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAnimateWidthandHeightofaEllipse";
            this.Text = "frmAnimateWidthandHeightofaEllipse";
            this.Load += new System.EventHandler(this.frmAnimateWidthandHeightofaEllipse_Load);
            this.ResumeLayout(false);

        }

        private void frmAnimateWidthandHeightofaEllipse_Load(object sender, EventArgs e)
        {

        }
    }
}
