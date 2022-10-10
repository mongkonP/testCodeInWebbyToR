using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1840__EventTrigger
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/EventTriggerEllipseMouseLeftButtonUp.htm
    public partial  class frmEventTriggerEllipseMouseLeftButtonUp:Form
    {
        public frmEventTriggerEllipseMouseLeftButtonUp()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEventTriggerEllipseMouseLeftButtonUp
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEventTriggerEllipseMouseLeftButtonUp";
            this.Text = "frmEventTriggerEllipseMouseLeftButtonUp";
            this.Load += new System.EventHandler(this.frmEventTriggerEllipseMouseLeftButtonUp_Load);
            this.ResumeLayout(false);

        }

        private void frmEventTriggerEllipseMouseLeftButtonUp_Load(object sender, EventArgs e)
        {

        }
    }
}
