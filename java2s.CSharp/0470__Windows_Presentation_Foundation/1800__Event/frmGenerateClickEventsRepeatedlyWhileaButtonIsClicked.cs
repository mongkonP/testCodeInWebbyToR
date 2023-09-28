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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/GenerateClickEventsRepeatedlyWhileaButtonIsClicked.htm
    public partial  class frmGenerateClickEventsRepeatedlyWhileaButtonIsClicked:Form
    {
        public frmGenerateClickEventsRepeatedlyWhileaButtonIsClicked()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGenerateClickEventsRepeatedlyWhileaButtonIsClicked
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGenerateClickEventsRepeatedlyWhileaButtonIsClicked";
            this.Text = "frmGenerateClickEventsRepeatedlyWhileaButtonIsClicked";
            this.Load += new System.EventHandler(this.frmGenerateClickEventsRepeatedlyWhileaButtonIsClicked_Load);
            this.ResumeLayout(false);

        }

        private void frmGenerateClickEventsRepeatedlyWhileaButtonIsClicked_Load(object sender, EventArgs e)
        {

        }
    }
}
