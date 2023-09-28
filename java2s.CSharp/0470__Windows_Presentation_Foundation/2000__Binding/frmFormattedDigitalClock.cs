using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2000__Binding
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/FormattedDigitalClock.htm
    public partial  class frmFormattedDigitalClock:Form
    {
        public frmFormattedDigitalClock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmFormattedDigitalClock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmFormattedDigitalClock";
            this.Text = "frmFormattedDigitalClock";
            this.Load += new System.EventHandler(this.frmFormattedDigitalClock_Load);
            this.ResumeLayout(false);

        }

        private void frmFormattedDigitalClock_Load(object sender, EventArgs e)
        {

        }
    }
}
