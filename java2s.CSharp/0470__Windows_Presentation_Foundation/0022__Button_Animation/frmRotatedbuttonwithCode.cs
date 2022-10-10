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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RotatedbuttonwithCode.htm
    public partial  class frmRotatedbuttonwithCode:Form
    {
        public frmRotatedbuttonwithCode()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRotatedbuttonwithCode
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRotatedbuttonwithCode";
            this.Text = "frmRotatedbuttonwithCode";
            this.Load += new System.EventHandler(this.frmRotatedbuttonwithCode_Load);
            this.ResumeLayout(false);

        }

        private void frmRotatedbuttonwithCode_Load(object sender, EventArgs e)
        {

        }
    }
}
