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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Eventsaddandremovefunctionsforaprivatedelegateevent.htm
    public partial  class frmEventsaddandremovefunctionsforaprivatedelegateevent:Form
    {
        public frmEventsaddandremovefunctionsforaprivatedelegateevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEventsaddandremovefunctionsforaprivatedelegateevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEventsaddandremovefunctionsforaprivatedelegateevent";
            this.Text = "frmEventsaddandremovefunctionsforaprivatedelegateevent";
            this.Load += new System.EventHandler(this.frmEventsaddandremovefunctionsforaprivatedelegateevent_Load);
            this.ResumeLayout(false);

        }

        private void frmEventsaddandremovefunctionsforaprivatedelegateevent_Load(object sender, EventArgs e)
        {

        }
    }
}
