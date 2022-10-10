using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1840__EventTrigger
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/StyleWithMultiTrigger.htm
    public partial  class frmStyleWithMultiTrigger:Form
    {
        public frmStyleWithMultiTrigger()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmStyleWithMultiTrigger
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmStyleWithMultiTrigger";
            this.Text = "frmStyleWithMultiTrigger";
            this.Load += new System.EventHandler(this.frmStyleWithMultiTrigger_Load);
            this.ResumeLayout(false);

        }

        private void frmStyleWithMultiTrigger_Load(object sender, EventArgs e)
        {

        }
    }
}
