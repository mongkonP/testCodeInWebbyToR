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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/UIElementMouseClickedEvents.htm
    public partial  class frmUIElementMouseClickedEvents:Form
    {
        public frmUIElementMouseClickedEvents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmUIElementMouseClickedEvents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmUIElementMouseClickedEvents";
            this.Text = "frmUIElementMouseClickedEvents";
            this.Load += new System.EventHandler(this.frmUIElementMouseClickedEvents_Load);
            this.ResumeLayout(false);

        }

        private void frmUIElementMouseClickedEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
