using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C1380__Rectangle
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/TriggeranimationwithRectangleMouseEnter.htm
    public partial  class frmTriggeranimationwithRectangleMouseEnter:Form
    {
        public frmTriggeranimationwithRectangleMouseEnter()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmTriggeranimationwithRectangleMouseEnter
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmTriggeranimationwithRectangleMouseEnter";
            this.Text = "frmTriggeranimationwithRectangleMouseEnter";
            this.Load += new System.EventHandler(this.frmTriggeranimationwithRectangleMouseEnter_Load);
            this.ResumeLayout(false);

        }

        private void frmTriggeranimationwithRectangleMouseEnter_Load(object sender, EventArgs e)
        {

        }
    }
}
