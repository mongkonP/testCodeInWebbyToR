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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/PenLineCapRound.htm
    public partial  class frmPenLineCapRound:Form
    {
        public frmPenLineCapRound()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmPenLineCapRound
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmPenLineCapRound";
            this.Text = "frmPenLineCapRound";
            this.Load += new System.EventHandler(this.frmPenLineCapRound_Load);
            this.ResumeLayout(false);

        }

        private void frmPenLineCapRound_Load(object sender, EventArgs e)
        {

        }
    }
}
