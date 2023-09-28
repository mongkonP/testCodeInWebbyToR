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
    //http://www.java2s.com/Tutorial/CSharp/0180__delegate/RetrievingEvenNumberedEvents.htm
    public partial  class frmRetrievingEvenNumberedEvents:Form
    {
        public frmRetrievingEvenNumberedEvents()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmRetrievingEvenNumberedEvents
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmRetrievingEvenNumberedEvents";
            this.Text = "frmRetrievingEvenNumberedEvents";
            this.Load += new System.EventHandler(this.frmRetrievingEvenNumberedEvents_Load);
            this.ResumeLayout(false);

        }

        private void frmRetrievingEvenNumberedEvents_Load(object sender, EventArgs e)
        {

        }
    }
}
