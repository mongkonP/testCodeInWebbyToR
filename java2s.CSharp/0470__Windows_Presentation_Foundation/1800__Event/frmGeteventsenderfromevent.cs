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
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Geteventsenderfromevent.htm
    public partial  class frmGeteventsenderfromevent:Form
    {
        public frmGeteventsenderfromevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmGeteventsenderfromevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmGeteventsenderfromevent";
            this.Text = "frmGeteventsenderfromevent";
            this.Load += new System.EventHandler(this.frmGeteventsenderfromevent_Load);
            this.ResumeLayout(false);

        }

        private void frmGeteventsenderfromevent_Load(object sender, EventArgs e)
        {

        }
    }
}
