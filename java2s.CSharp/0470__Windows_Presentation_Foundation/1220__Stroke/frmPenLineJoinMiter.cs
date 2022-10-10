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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PenLineJoinMiter.htm
    public partial  class frmPenLineJoinMiter:Form
    {
        public frmPenLineJoinMiter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPenLineJoinMiter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPenLineJoinMiter";
            this.Text = "frmPenLineJoinMiter";
            this.Load += new System.EventHandler(this.frmPenLineJoinMiter_Load);
            this.ResumeLayout(false);

        }

        private void frmPenLineJoinMiter_Load(object sender, EventArgs e)
        {

        }
    }
}
