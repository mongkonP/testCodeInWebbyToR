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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PenLineJoinRound.htm
    public partial  class frmPenLineJoinRound:Form
    {
        public frmPenLineJoinRound()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPenLineJoinRound
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPenLineJoinRound";
            this.Text = "frmPenLineJoinRound";
            this.Load += new System.EventHandler(this.frmPenLineJoinRound_Load);
            this.ResumeLayout(false);

        }

        private void frmPenLineJoinRound_Load(object sender, EventArgs e)
        {

        }
    }
}
