using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0221__RadioButton_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/RadioButtonclickevent.htm
    public partial  class frmRadioButtonclickevent:Form
    {
        public frmRadioButtonclickevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRadioButtonclickevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRadioButtonclickevent";
            this.Text = "frmRadioButtonclickevent";
            this.Load += new System.EventHandler(this.frmRadioButtonclickevent_Load);
            this.ResumeLayout(false);

        }

        private void frmRadioButtonclickevent_Load(object sender, EventArgs e)
        {

        }
    }
}
