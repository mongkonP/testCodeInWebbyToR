using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0022__Button_Animation
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/ScaledbuttonwithCode.htm
    public partial  class frmScaledbuttonwithCode:Form
    {
        public frmScaledbuttonwithCode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmScaledbuttonwithCode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmScaledbuttonwithCode";
            this.Text = "frmScaledbuttonwithCode";
            this.Load += new System.EventHandler(this.frmScaledbuttonwithCode_Load);
            this.ResumeLayout(false);

        }

        private void frmScaledbuttonwithCode_Load(object sender, EventArgs e)
        {

        }
    }
}
