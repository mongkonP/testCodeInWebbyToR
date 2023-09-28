using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1800__Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Casteventsendertoacontrol.htm
    public partial  class frmCasteventsendertoacontrol:Form
    {
        public frmCasteventsendertoacontrol()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmCasteventsendertoacontrol
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmCasteventsendertoacontrol";
            this.Text = "frmCasteventsendertoacontrol";
            this.Load += new System.EventHandler(this.frmCasteventsendertoacontrol_Load);
            this.ResumeLayout(false);

        }

        private void frmCasteventsendertoacontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
