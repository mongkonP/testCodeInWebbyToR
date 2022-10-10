using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C0161__CheckBox_Event
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/HandleCheckBoxUncheckedevents.htm
    public partial  class frmHandleCheckBoxUncheckedevents:Form
    {
        public frmHandleCheckBoxUncheckedevents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmHandleCheckBoxUncheckedevents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmHandleCheckBoxUncheckedevents";
            this.Text = "frmHandleCheckBoxUncheckedevents";
            this.Load += new System.EventHandler(this.frmHandleCheckBoxUncheckedevents_Load);
            this.ResumeLayout(false);

        }

        private void frmHandleCheckBoxUncheckedevents_Load(object sender, EventArgs e)
        {

        }
    }
}
