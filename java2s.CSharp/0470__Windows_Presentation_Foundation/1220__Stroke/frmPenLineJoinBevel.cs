using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1220__Stroke
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PenLineJoinBevel.htm
    public partial  class frmPenLineJoinBevel:Form
    {
        public frmPenLineJoinBevel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPenLineJoinBevel
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPenLineJoinBevel";
            this.Text = "frmPenLineJoinBevel";
            this.Load += new System.EventHandler(this.frmPenLineJoinBevel_Load);
            this.ResumeLayout(false);

        }

        private void frmPenLineJoinBevel_Load(object sender, EventArgs e)
        {

        }
    }
}
