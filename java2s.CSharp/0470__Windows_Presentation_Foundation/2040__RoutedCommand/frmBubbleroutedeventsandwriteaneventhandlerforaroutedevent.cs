using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TORServices.Forms;
namespace java2s.CSharp.C0470__Windows_Presentation_Foundation.C2040__RoutedCommand
{
    //http://www.java2s.com/Tutorial/CSharp/0470__Windows-Presentation-Foundation/Bubbleroutedeventsandwriteaneventhandlerforaroutedevent.htm
    public partial  class frmBubbleroutedeventsandwriteaneventhandlerforaroutedevent:Form
    {
        public frmBubbleroutedeventsandwriteaneventhandlerforaroutedevent()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmBubbleroutedeventsandwriteaneventhandlerforaroutedevent
            // 
            this.ClientSize = new System.Drawing.Size(756, 454);
            this.Name = "frmBubbleroutedeventsandwriteaneventhandlerforaroutedevent";
            this.Text = "frmBubbleroutedeventsandwriteaneventhandlerforaroutedevent";
            this.Load += new System.EventHandler(this.frmBubbleroutedeventsandwriteaneventhandlerforaroutedevent_Load);
            this.ResumeLayout(false);

        }

        private void frmBubbleroutedeventsandwriteaneventhandlerforaroutedevent_Load(object sender, EventArgs e)
        {

        }
    }
}
