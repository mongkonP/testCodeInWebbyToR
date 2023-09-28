using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2360__BackgroundWorker
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UseBackgroundWorkertoruntaskatbackground.htm
    public partial  class frmUseBackgroundWorkertoruntaskatbackground:Form
    {
        public frmUseBackgroundWorkertoruntaskatbackground()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUseBackgroundWorkertoruntaskatbackground
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUseBackgroundWorkertoruntaskatbackground";
            this.Text = "frmUseBackgroundWorkertoruntaskatbackground";
            this.Load += new System.EventHandler(this.frmUseBackgroundWorkertoruntaskatbackground_Load);
            this.ResumeLayout(false);

        }

        private void frmUseBackgroundWorkertoruntaskatbackground_Load(object sender, EventArgs e)
        {

        }
    }
}
