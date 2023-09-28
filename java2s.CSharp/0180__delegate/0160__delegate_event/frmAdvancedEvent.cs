using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0180__delegate.C0160__delegate_event
{
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/AdvancedEvent.htm
    public partial  class frmAdvancedEvent:Form
    {
        public frmAdvancedEvent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmAdvancedEvent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmAdvancedEvent";
            this.Text = "frmAdvancedEvent";
            this.Load += new System.EventHandler(this.frmAdvancedEvent_Load);
            this.ResumeLayout(false);

        }

        private void frmAdvancedEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
