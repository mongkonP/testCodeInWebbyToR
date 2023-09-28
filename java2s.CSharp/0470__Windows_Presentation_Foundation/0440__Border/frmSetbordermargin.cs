using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0440__Border
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Setbordermargin.htm
    public partial  class frmSetbordermargin:Form
    {
        public frmSetbordermargin()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmSetbordermargin
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmSetbordermargin";
            this.Text = "frmSetbordermargin";
            this.Load += new System.EventHandler(this.frmSetbordermargin_Load);
            this.ResumeLayout(false);

        }

        private void frmSetbordermargin_Load(object sender, EventArgs e)
        {

        }
    }
}
