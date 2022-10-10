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
    //http://www.java2s.com/Tutorial/CSharp/0460__GUI-Windows-Forms/Eventsaddandremovewithsynchronizedblock.htm
    public partial  class frmEventsaddandremovewithsynchronizedblock:Form
    {
        public frmEventsaddandremovewithsynchronizedblock()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmEventsaddandremovewithsynchronizedblock
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmEventsaddandremovewithsynchronizedblock";
            this.Text = "frmEventsaddandremovewithsynchronizedblock";
            this.Load += new System.EventHandler(this.frmEventsaddandremovewithsynchronizedblock_Load);
            this.ResumeLayout(false);

        }

        private void frmEventsaddandremovewithsynchronizedblock_Load(object sender, EventArgs e)
        {

        }
    }
}
