using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1021__Window_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/WindowLoadedevent.htm
    public partial  class frmWindowLoadedevent:Form
    {
        public frmWindowLoadedevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmWindowLoadedevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmWindowLoadedevent";
            this.Text = "frmWindowLoadedevent";
            this.Load += new System.EventHandler(this.frmWindowLoadedevent_Load);
            this.ResumeLayout(false);

        }

        private void frmWindowLoadedevent_Load(object sender, EventArgs e)
        {

        }
    }
}
