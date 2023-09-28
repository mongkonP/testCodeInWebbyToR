using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0061__TextBlock_Style
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EmpiricalTiltedTextShadow.htm
    public partial  class frmEmpiricalTiltedTextShadow:Form
    {
        public frmEmpiricalTiltedTextShadow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEmpiricalTiltedTextShadow
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEmpiricalTiltedTextShadow";
            this.Text = "frmEmpiricalTiltedTextShadow";
            this.Load += new System.EventHandler(this.frmEmpiricalTiltedTextShadow_Load);
            this.ResumeLayout(false);

        }

        private void frmEmpiricalTiltedTextShadow_Load(object sender, EventArgs e)
        {

        }
    }
}
