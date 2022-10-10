using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1880__Mouse
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/MouseLostMouseCaptureEvent.htm
    public partial  class frmMouseLostMouseCaptureEvent:Form
    {
        public frmMouseLostMouseCaptureEvent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMouseLostMouseCaptureEvent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmMouseLostMouseCaptureEvent";
            this.Text = "frmMouseLostMouseCaptureEvent";
            this.Load += new System.EventHandler(this.frmMouseLostMouseCaptureEvent_Load);
            this.ResumeLayout(false);

        }

        private void frmMouseLostMouseCaptureEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
