using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2560__MediaElement
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/DeclarativePlayback.htm
    public partial  class frmDeclarativePlayback:Form
    {
        public frmDeclarativePlayback()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmDeclarativePlayback
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmDeclarativePlayback";
            this.Text = "frmDeclarativePlayback";
            this.Load += new System.EventHandler(this.frmDeclarativePlayback_Load);
            this.ResumeLayout(false);

        }

        private void frmDeclarativePlayback_Load(object sender, EventArgs e)
        {

        }
    }
}
