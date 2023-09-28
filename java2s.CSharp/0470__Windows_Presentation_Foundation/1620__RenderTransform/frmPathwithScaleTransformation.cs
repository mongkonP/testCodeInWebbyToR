using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1620__RenderTransform
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PathwithScaleTransformation.htm
    public partial  class frmPathwithScaleTransformation:Form
    {
        public frmPathwithScaleTransformation()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPathwithScaleTransformation
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPathwithScaleTransformation";
            this.Text = "frmPathwithScaleTransformation";
            this.Load += new System.EventHandler(this.frmPathwithScaleTransformation_Load);
            this.ResumeLayout(false);

        }

        private void frmPathwithScaleTransformation_Load(object sender, EventArgs e)
        {

        }
    }
}
