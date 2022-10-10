using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1200__Color
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseSystemColortodrawLine.htm
    public partial  class frmUseSystemColortodrawLine:Form
    {
        public frmUseSystemColortodrawLine()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseSystemColortodrawLine
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseSystemColortodrawLine";
            this.Text = "frmUseSystemColortodrawLine";
            this.Load += new System.EventHandler(this.frmUseSystemColortodrawLine_Load);
            this.ResumeLayout(false);

        }

        private void frmUseSystemColortodrawLine_Load(object sender, EventArgs e)
        {

        }
    }
}
