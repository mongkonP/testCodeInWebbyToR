using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0460__GUI_Windows_Forms.C1280__event
{
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Eventsandformcontrols.htm
    public partial  class frmEventsandformcontrols:Form
    {
        public frmEventsandformcontrols()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEventsandformcontrols
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEventsandformcontrols";
            this.Text = "frmEventsandformcontrols";
            this.Load += new System.EventHandler(this.frmEventsandformcontrols_Load);
            this.ResumeLayout(false);

        }

        private void frmEventsandformcontrols_Load(object sender, EventArgs e)
        {

        }
    }
}
